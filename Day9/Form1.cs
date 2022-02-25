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
    public partial class Form1 : Form
    {
        FrmMsg frmMsg;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            //ColorDialog dlg = new ColorDialog();

            //if (dlg.ShowDialog() == DialogResult.OK)
            //    lblMsg.ForeColor = dlg.Color;

            //if(fontDialog1.ShowDialog() == DialogResult.OK)
            //    lblMsg.Font = fontDialog1.Font;

            openFileDialog1.Filter = "PNG images| *.png|JPG imaged|*.jpg|All|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnOpenForm_Click(object sender, EventArgs e)
        {
            frmMsg = new FrmMsg(txtMsg.Text);
            frmMsg.FormClosed += FrmMsg_FormClosed;
            frmMsg.InfoChanged += FrmMsg_InfoChanged;
            //frmMsg.Info = txtMsg.Text;
            frmMsg.Show();
            //txtMsg.Text = frmMsg.Info;
        }

        private void FrmMsg_InfoChanged(object sender, EventArgs e)
        {
            txtMsg.Text = frmMsg.Info;
        }

        private void FrmMsg_FormClosed(object sender, FormClosedEventArgs e)
        {
            txtMsg.Text = frmMsg.Info;
        }

        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            frmMsg.Info = txtMsg.Text;
        }
    }
}
