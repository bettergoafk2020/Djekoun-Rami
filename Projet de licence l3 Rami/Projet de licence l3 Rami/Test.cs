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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RNA_test rNA_Test= new RNA_test();
            rNA_Test.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SVM_testcs sVM_Testcs = new SVM_testcs();
            sVM_Testcs.Show();
            this.Hide();
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }
    }
}
