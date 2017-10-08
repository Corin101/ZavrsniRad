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
                ServerBuilder server = new ServerBuilder(portNumber);
                server.StartListener();
            }
            else
            {
                displayBox.AppendText("Nope\n");
            }
        }

        private bool CheckPort(string txtPortNumber)
        {
            return (Int32.TryParse(txtPortNumber, out portNumber) && (portNumber < 65536));
        }


        private int portNumber;
    }
}
