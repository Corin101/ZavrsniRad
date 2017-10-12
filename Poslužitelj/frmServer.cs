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
        private bool CheckPort(string txtPortNumber)
        {
            return Int32.TryParse(txtPortNumber, out portNumber) && (portNumber < 65536);
        }

        private bool ValidateClient()
        {
            return (Convert.ToInt32(ClientValidation.SelectedIndex) == 1);
        }

        private void txtCert_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string cert;
                cert = dlg.FileName;
                txtCert.Text = "Loaded!";
                certificate.Import(cert);
                certificate = new X509Certificate();
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = true;
            txtCert.Visible = true;
            chckName.Visible = false;
            txtcertName.Visible = false;
            label5.Visible = false;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
            txtCert.Visible = false;
            chckName.Visible = true;
            txtcertName.Visible = true;
            label5.Visible = true;
        }
        private void chckName_CheckedChanged(object sender, EventArgs e)
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

        private bool VerifyCertName()
        {
            string result;
            try
            {
                result = txtcertName.Text.Substring(txtcertName.Text.Length - 4);
            }
            catch
            {
                return false;
            }          
            return result == ".cer" && result.Length > 4;

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
        private int portNumber;
        private string certificateName;
        private X509Certificate certificate;


    }
}
