using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day9
{
    public partial class FrmMsg : Form
    {
        public event EventHandler InfoChanged; 
        public FrmMsg(string msg)
        {
            InitializeComponent();

            txtInfo.Text = msg;
        }

        public string Info 
        {
            get { return txtInfo.Text; }
            set { txtInfo.Text = value; }
        }

        private void FrmMsg_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Do u want to close the form?", "This is a caption",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txtInfo_TextChanged(object sender, EventArgs e)
        {
            if(InfoChanged != null)
                InfoChanged(this, new EventArgs());
        }
    }
}
