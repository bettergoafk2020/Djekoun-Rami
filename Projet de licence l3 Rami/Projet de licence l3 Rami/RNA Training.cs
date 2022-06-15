using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Projet_de_licence_l3_Rami
{
    public partial class RNA_Training : Form
    {
        public RNA_Training()
        {
            InitializeComponent();
        }

        private void button_brows_save_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txt_save.Text = folderBrowserDialog1.SelectedPath;
        }
        private void python_script()
        {

            // 1) Create Process Info
            var psi = new ProcessStartInfo();
            psi.FileName = @"C:\Users\MSI MODERN\AppData\Local\Programs\Python\Python39\python.exe";

            // 2) Provide script and arguments
            var script = @"C:\Users\MSI MODERN\Desktop\python folder\python scripto\RNA model\Rna model train.py";

            var test = txt_test_chemain.Text;
            var train = txt_chemain_train.Text;
            var save = txt_save.Text;

            psi.Arguments = $"\"{script}\" \"{train}\" \"{test}\" \"{save}\"";


            // 3) Process configuration
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = false;
            psi.RedirectStandardError = true;

            // 4) Execute process and get output


            var errors = "";
            //var results = "";



            using (var process = Process.Start(psi))
            {
                errors = process.StandardError.ReadToEnd();
                //results = process.StandardOutput.ReadToEnd();
            }




            // 5) Display output
            //Console.WriteLine("ERRORS:");
            //Console.WriteLine(errors);
            MessageBox.Show("Errors or warnings :" + errors);
            //Console.WriteLine();
            //Console.WriteLine("Results:");
            //Console.WriteLine(results);
            //txt_result.Text = results;

            /*
            StreamWriter sw = new StreamWriter(txt_save.Text+ @"\CNN_result.txt");

            sw.Write(results);

            sw.Close();*/

        }
        private void button_parcourir_train_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\Users\MSI MODERN\Desktop\python folder\python scripto\RNA model";
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            string train_file = openFileDialog1.FileName;
            txt_chemain_train.Text = train_file;
        }

        private void button_brows_test_Click(object sender, EventArgs e)
        {
            openFileDialog2.InitialDirectory = @"C:\Users\MSI MODERN\Desktop\python folder\python scripto";
            openFileDialog2.Filter = "All files (*.*)|*.*";
            openFileDialog2.ShowDialog();
            string test_file = openFileDialog2.FileName;
            txt_test_chemain.Text = test_file;
         }

        private void button_lunch_Click(object sender, EventArgs e)
        {
            python_script();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Learning_page retour = new Learning_page();
            retour.Show();
            this.Hide();
        }
    }
    }


