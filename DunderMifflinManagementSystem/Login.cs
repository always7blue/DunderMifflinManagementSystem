using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DunderMifflinManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();                       // uygulamadan çıkmak için kullanılır
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UIdTb.Text == "" || PassTb.Text == "")
            {
                MessageBox.Show("Enter User Name Or User Password");
            }
            else if (UIdTb.Text == "worlds" && PassTb.Text == "bestboss")
            {
                this.Hide();
                Home home = new Home();             //anasayfaya gitmek için kullanılır
                home.Show();
            }
            else
            {
                MessageBox.Show("Wrong User Name or Password");
            }
        }
    }
}
