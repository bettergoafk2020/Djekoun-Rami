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
    public partial class Learning_page : Form
    {
        public Learning_page()
        {
            InitializeComponent();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RNA_Training rNA_Training = new RNA_Training();
            rNA_Training.Show();
            this.Hide();

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Svm_Train_page svm_Train_Page = new Svm_Train_page();
            svm_Train_Page.Show();
            this.Hide();
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Data_Base go1 = new Data_Base();
            go1.Show();
            this.Hide();
        }
    }
}
