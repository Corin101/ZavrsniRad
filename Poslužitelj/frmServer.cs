using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            if (CheckPort(txtPortNumber.Text))
            {
                ServerBuilder server = new ServerBuilder(portNumber,ValidateClient());
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
            return (Int32.TryParse(txtPortNumber, out portNumber) && (portNumber < 65536));
        }
        /// <summary>
        /// Provjera ako server traži validaciju klijenta
        /// </summary>
        /// <returns>0 = false 1 = true </returns>
        private bool ValidateClient()
        {
            return (Convert.ToInt32(ClientValidation.SelectedValue) == 1);
        }


        private int portNumber;
    }
}
