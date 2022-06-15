using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_de_licence_l3_Rami
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            if ((txt_password.Text == "mdpadmin") && (txt_username.Text == "admin"))
            {
                Learning_page learn = new Learning_page();
                learn.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Username or password incorrect !");
                txt_username.Text = "";
                txt_password.Text = "";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Test form = new Test();
            form.Show();
            this.Hide();

        }
    }
}
