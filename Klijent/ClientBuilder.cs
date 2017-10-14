using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    class ClientBuilder
    {
        public ClientBuilder(string srvName, string serverCertName, int portNumber, string msg)
        {
            serverName = srvName;
            serverCertificateName = serverCertName;
            listeninigPort = portNumber;
            messageToServer = msg;
        }

        public void RunClient()
        {
            client = new TcpClient(serverName, listeninigPort);
            sslStream = new SslStream(client.GetStream(), false, new RemoteCertificateValidationCallback(ValidateServerCertificate), null);
            try
            {
                sslStream.AuthenticateAsClient(serverCertificateName);
            }
            catch (Exception e)
            {
                if (e.InnerException != null)
                {
                    mainForm.SetText("Inner exception: "+ e.InnerException.Message);
                }
                client.Close();
                mainForm.DisableStart();
                return;
            }
            byte[] messsage = Encoding.UTF8.GetBytes(messageToServer + "<EOF>");
            mainForm.SetText("Message sent to server: " + messageToServer);
            sslStream.Write(messsage);
            sslStream.Flush();
            string serverMessage = ReadMessage(sslStream);
            mainForm.SetText("Server says: " + serverMessage);
            writeFlag = false;           
            client.Close();
            mainForm.DisableStart();
        }

        public bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            if (sslPolicyErrors == SslPolicyErrors.None)
                return true;
            mainForm.SetText("Certificate error: " + sslPolicyErrors);
            return false;
        }
        private string ReadMessage(SslStream sslStream)
        {
            // Read the  message sent by the server. The end of the message is signaled using the "<EOF>" marker.
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
                // Check for EOF.
                if (messageData.ToString().IndexOf("<EOF>") != -1)
                {
                    break;
                }
            } while (bytes != 0);
            return messageData.ToString();
        }

        private string serverName;
        private string serverCertificateName;
        public string messageToServer;
        private Hashtable certificateErrors = new Hashtable();
        private int listeninigPort;
        public bool writeFlag = false;
        public bool endChat = false;
        frmClient mainForm = (frmClient)Application.OpenForms[0];
        TcpClient client;
        SslStream sslStream;
    }
}
