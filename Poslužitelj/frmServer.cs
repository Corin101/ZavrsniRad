using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poslužitelj
{
    public partial class frmServer : Form
    {
        #region CONSTRUCTORS
        public frmServer()
        {
            InitializeComponent();
            ClientValidation.SelectedIndex = 0;
        }
        #endregion
        #region START SERVER
        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (portNumber == 0 || (certificate == null && certificateName == null))
            {
                SetText("Port Number, certificate or certificate name must be filled!");
            }
            else
            {
                ServerBuilder server;
                Thread ListenerThread;
                SetText("Starting Server!");
                if (certificateName == null)
                {
                    server = new ServerBuilder(portNumber, certificate);
                    DisableStart();
                    ListenerThread = new Thread(new ThreadStart(server.StartListener));                
                }
                else
                {
                    server = new ServerBuilder(portNumber, certificateName);
                    DisableStart();
                    ListenerThread = new Thread(new ThreadStart(server.StartListener));                   
                }
                ListenerThread.Start();
            }
        }
        public void DisableStart()
        {
            if (this.InvokeRequired)
            {
                this.Invoke((Action)(() => btnStart.Enabled = true));
                return;
            }
            btnStart.Enabled = false;
        }
        #endregion
        #region VALIDATION
        private bool CheckPort(string txtPortNumber)
        {
            return Int32.TryParse(txtPortNumber, out portNumber) && (portNumber < 65536);
        }
        private bool ValidateClient()
        {
            return (Convert.ToInt32(ClientValidation.SelectedIndex) == 1);
        }
        private bool VerifyCertName()
        {
            return !(txtcertName.Text.Length == 0);         
        }
        private void TxtCert_Click(object sender, EventArgs e)
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
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = true;
            txtCert.Visible = true;
            chckName.Visible = false;
            txtcertName.Visible = false;
            label5.Visible = false;
        }
        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
            txtCert.Visible = false;
            chckName.Visible = true;
            txtcertName.Visible = true;
            label5.Visible = true;
        }
        private void ChckName_CheckedChanged(object sender, EventArgs e)
        {
            if (chckName.Checked)
            {
                certificateName = txtcertName.Text;
                txtcertName.Enabled = false;
                if (!VerifyCertName())
                    txtcertName.Text = "Wrong Input";
            }
            else
            {
                txtcertName.Text = "";
                txtcertName.Enabled = true;
            }
        }
        private void ChckPort_CheckedChanged(object sender, EventArgs e)
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
        #endregion
        #region TOOLTIPS & TEXT
        private void TxtPortNumber_Click(object sender, EventArgs e)
        {
            int durationMilliseconds = 10000;
            toolTip1.Show(toolTip1.GetToolTip(txtPortNumber), txtPortNumber, durationMilliseconds);
        }
        private void txtcertName_Click(object sender, EventArgs e)
        {
            int durationMilliseconds = 10000;
            toolTip1.Show(toolTip1.GetToolTip(txtcertName), txtcertName, durationMilliseconds);
        }
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
        #region VARIABLES
        delegate void SetTextCallback(string text);
        private int portNumber;
        private string certificateName;
        private X509Certificate certificate;
        #endregion
    }
}
