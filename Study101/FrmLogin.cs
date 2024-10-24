using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study101
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "Nadya" && txtPassword.Text == "Pagiling")
            {
                Dashboard frmMain = new Dashboard();
                frmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Anda salah menginput Username dan Password");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
