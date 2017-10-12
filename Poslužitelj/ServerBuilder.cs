﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Poslužitelj
{
    public class ServerBuilder
    {
        #region CONSTRUSTORS
        public ServerBuilder(int portNumber,X509Certificate certificate)
        {
            PortAdress = portNumber;
            clientCertificate = certificate;
        }
        public ServerBuilder(int portNumber, string certName)
        {
            PortAdress = portNumber;
            certificateName = certName;
        }

        #endregion


        public void StartListener()
        {
            TcpListener listener = new TcpListener(IPAddress.Any, PortAdress);
            listener.Start();

            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                ValidationAndCommunication(client);
                    //retrun if successfull
            }

        }

        private bool ValidationAndCommunication(TcpClient client)
        {
            serverCertificate = new X509Certificate();
            GetCertificateFromStore();
            bool success = true;

            SslStream sslStream = new SslStream(client.GetStream(),false);
            try
            {
                sslStream.AuthenticateAsServer(serverCertificate, requestClientCertificate, SslProtocols.Tls, true);

                sslStream.ReadTimeout = 5000;
                sslStream.WriteTimeout = 5000;

                string messageData = ReadMessage(sslStream);

                // Write a message to the client.
                byte[] message = Encoding.UTF8.GetBytes("Server has received your msg!.<EOF>");
                sslStream.Write(message);
            }
            catch (AuthenticationException expt)
            {
                success = false;
                // propagate expt msg
            }
            finally
            {
                sslStream.Close();
                client.Close();
            }
            return success;
        }


        static string ReadMessage(SslStream sslStream)
        {
            byte[] buffer = new byte[2048];
            StringBuilder messageData = new StringBuilder();
            int bytes = -1;
            do
            {
                bytes = sslStream.Read(buffer, 0, buffer.Length);

                // Use Decoder class to convert from bytes to UTF8 in case a character spans two buffers.
                Decoder decoder = Encoding.UTF8.GetDecoder();
                char[] chars = new char[decoder.GetCharCount(buffer, 0, bytes)];
                decoder.GetChars(buffer, 0, bytes, chars, 0);
                messageData.Append(chars);
                // Check for EOF or an empty message.
                if (messageData.ToString().IndexOf("<EOF>") != -1)
                {
                    break;
                }
            } while (bytes != 0);

            return messageData.ToString();
        }
        private void GetCertificateFromStore()
        {
            X509Store store = new X509Store(StoreName.Root, StoreLocation.LocalMachine);
            store.Open(OpenFlags.ReadOnly);
            var certificates = store.Certificates.Find(X509FindType.FindBySubjectDistinguishedName, certificateName, false);
            store.Close();

            if (certificates.Count == 0)
            {
                return;
            }
            else
            {
                serverCertificate = certificates[0];
            }
        }

#region VARIABLES AND PROPERIES 
        private bool requestClientCertificate = false;
        private string certificateName;
        private X509Certificate serverCertificate = null;
        private X509Certificate clientCertificate = null;
        private int PortAdress { get; set; }
        #endregion
    }
}
