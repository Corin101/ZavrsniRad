using System;
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

        #endregion


        public void StartListener()
        {
            TcpListener listener = new TcpListener(IPAddress.Any, PortAdress);
            listener.Start();
            TcpClient client = listener.AcceptTcpClient();
        }


        private bool CheckValidation(TcpClient client)
        {
            SslStream sslStream = new SslStream(client.GetStream(),false);
            sslStream.AuthenticateAsServer(serverCertificate, requestClientCertificate, SslProtocols.Tls, true);



            return false;
        }



        #region VARIABLES AND PROPERIES 
        private bool requestClientCertificate = false;
        private X509Certificate serverCertificate = null;
        private X509Certificate clientCertificate = null;
        private int PortAdress { get; set; }
        #endregion
    }
}
