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
    class ServerBuilder
    {
        #region CONSTRUSTORS
        public ServerBuilder(int portNumber)
        {
            PortAdress = portNumber;
        }

        #endregion

        public void StartListener()
        {
            TcpListener listener = new TcpListener(IPAddress.Any, PortAdress);
            listener.Start();
            TcpClient client = listener.AcceptTcpClient();
        }






        #region VARIABLES AND PROPERIES 
        public string ListeningPort { set; get; }
        private X509Certificate serverCertificate = null;
        private int PortAdress { get; set; } = 433;
        #endregion
    }
}
