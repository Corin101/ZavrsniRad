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
    class ServerBuilder
    {
        #region CONSTRUSTORS
        public ServerBuilder(int ipAddress)
        {
            PortAdress = ipAddress;
        }

        public ServerBuilder(IPAddress ipAdress, int portAdress)
        {
            IpAddress = ipAdress;
            PortAdress = portAdress;
        }
        #endregion

        private void Listener()
        {
            TcpListener listener = new TcpListener(IpAddress, PortAdress);
            listener.Start();
            TcpClient client = listener.AcceptTcpClient();
        }






        #region VARIABLES AND PROPERIES 
        public string ListeningPort { set; get; }
        private X509Certificate serverCertificate = null;
        private IPAddress IpAddress { get; set; } = IPAddress.Any;
        private int PortAdress { get; set; } = 433;
        #endregion
    }
}
