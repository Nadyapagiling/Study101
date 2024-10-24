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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        } 

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Profile_Click(object sender, EventArgs e)
        {
            Profile frmMain = new Profile();
            frmMain.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Profile frmMain = new Profile();
            frmMain.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calendar_Tracker frmMain = new Calendar_Tracker();
            frmMain.Show();
            this.Hide();
        }
    }
}
