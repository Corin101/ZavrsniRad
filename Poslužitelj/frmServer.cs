using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poslužitelj
{
    public partial class frmServer : Form
    {
        public frmServer()
        {
            InitializeComponent();
            ClientValidation.SelectedIndex = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (CheckPort(txtPortNumber.Text))
            {
                ServerBuilder server = new ServerBuilder(portNumber, certificate);
                server.StartListener();
            }
            else
            {
                displayBox.AppendText("Nope\n");
            }
        }

        /// <summary>
        /// Provjera ako je portNumber dobro upisan , port number može biti od 1 do 65535
        /// </summary>
        /// <param name="txtPortNumber">string varijabla koja sadrži port</param>
        /// <returns>rezultat parsiranja</returns>
        private bool CheckPort(string txtPortNumber)
        {
            return Int32.TryParse(txtPortNumber, out portNumber) && (portNumber < 65536);
        }
        /// <summary>
        /// Provjera ako server traži validaciju klijenta
        /// </summary>
        /// <returns>0 = false 1 = true </returns>
        private bool ValidateClient()
        {
            return (Convert.ToInt32(ClientValidation.SelectedValue) == 1);
        }
        /// <summary>
        /// Otvara .cer datoteku u X509certificate
        /// </summary>
        private void LoadCertificate(string cert)
        {
            if (ValidateClient())
            {
                certificate = new X509Certificate();
                certificate.Import(cert);
            }
            else
                certificate = null;
        }

        private void txtCert_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string cert;
                cert = dlg.FileName;
                txtCert.Text = "Loaded!";
                LoadCertificate(cert);
            }
        }


        private int portNumber;
        private X509Certificate certificate;
    }
}
