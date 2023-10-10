using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginCode2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtPassword.UseSystemPasswordChar = true;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(TxtUsername.Text=="rolly" && TxtPassword.Text == "12345")
            {
                FrmMain frmMain = new FrmMain();
                frmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Anda salah input username atau password");
            }
        }

        private void ChBShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(ChBShowPassword.Checked==true) 
            {
                TxtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                TxtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
