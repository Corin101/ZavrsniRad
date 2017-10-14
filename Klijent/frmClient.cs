using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public partial class frmClient : Form
    {
        #region CONSTRUCTORS
        public frmClient()
        {
            InitializeComponent();
        }
        #endregion
        #region CLIENT CONFIG
        private void btnStart_Click(object sender, EventArgs e)
        {

            client = new ClientBuilder(serverName, serverCertificateName, portNumber);
            DisableStart();
            ClientThread = new Thread(new ThreadStart(client.RunClient));

        }
        public void DisableStart()
        {
            if (InvokeRequired)
            {
                Invoke((Action)(() => btnStart.Enabled = true));
                return;
            }
            btnStart.Enabled = false;
        }
        private void btnEndChat_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            txtMsgToServer.Visible = false;
            client.endChat = true;
        }
        private void txtMsgToServer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                client.messageToServer = txtMsgToServer.Text;
                txtMsgToServer.Text = "";
                e.Handled = true;
            }
        }
        public void sendMsgAvailable()
        {
            label7.Visible = true;
            txtMsgToServer.Visible = true;
        }

        #endregion
        #region TOOLTIPS & TEXT
        public void SetText(string text)
        {
            string txt = text;
            if (displayBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                Invoke(d, new object[] { text });
            }
            else
            {
                displayBox.AppendText(text + Environment.NewLine);
            }
        }
        #endregion
        #region VALIDATION
        private bool VerifyCertName(string txt)
        {
            return !(txt.Length == 0);
        }
        private bool CheckPort(string txtPortNumber)
        {
            return Int32.TryParse(txtPortNumber, out portNumber) && (portNumber < 65536);
        }
        private void txtCert_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string cert;
                cert = dlg.FileName;
                txtCert.Text = "Loaded!";
                certificate = new X509Certificate();
                certificate.Import(cert);
            }
        }
        #endregion
        #region RADIOBUTTONS & TEXTBOXES 
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = true;
            txtCert.Visible = true;
            chckName.Visible = false;
            txtcertName.Visible = false;
            label5.Visible = false;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = false;
            txtCert.Visible = false;
            chckName.Visible = true;
            txtcertName.Visible = true;
            label5.Visible = true;
        }
        private void chckPort_CheckedChanged(object sender, EventArgs e)
        {
            if (chckPort.Checked)
            {
                if (CheckPort(txtPortNumber.Text))
                    txtPortNumber.Enabled = false;
                else
                {
                    txtPortNumber.Text = "Wrong Input";
                    txtPortNumber.Enabled = false;
                }
            }
            else
            {
                txtPortNumber.Text = "";
                txtPortNumber.Enabled = true;
            }
        }
        private void chckServerName_CheckedChanged(object sender, EventArgs e)
        {
            if (chckServerName.Checked)
            {
                serverName = txtServerName.Text;
                txtServerName.Enabled = false;
                if (!VerifyCertName(serverName))
                    txtServerName.Text = "Wrong Input";
            }
            else
            {
                txtServerName.Text = "";
                txtServerName.Enabled = true;
            }
        }
        private void chckServerCertName_CheckedChanged(object sender, EventArgs e)
        {
            if (chckServerCertName.Checked)
            {
                serverCertificateName = txtServerCertName.Text;
                txtServerCertName.Enabled = false;
                if (!VerifyCertName(serverCertificateName))
                    txtServerCertName.Text = "Wrong Input";
            }
            else
            {
                txtServerCertName.Text = "";
                txtServerCertName.Enabled = true;
            }
        }
        private void chckName_CheckedChanged(object sender, EventArgs e)
        {
            if (chckName.Checked)
            {
                clientCertificateName = txtcertName.Text;
                txtcertName.Enabled = false;
                if (!VerifyCertName(clientCertificateName))
                    txtcertName.Text = "Wrong Input";
            }
            else
            {
                txtcertName.Text = "";
                txtcertName.Enabled = true;
            }
        }
        #endregion
        #region VARIABLES
        delegate void SetTextCallback(string text);
        private string clientCertificateName;
        private int portNumber;
        private string serverName;
        private string serverCertificateName;
        private X509Certificate certificate;
        ClientBuilder client;
        Thread ClientThread;
        #endregion
    }
}
