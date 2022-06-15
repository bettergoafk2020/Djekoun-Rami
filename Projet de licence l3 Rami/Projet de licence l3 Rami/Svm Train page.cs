using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projet_de_licence_l3_Rami
{
    public partial class Svm_Train_page : Form
    {
        public Svm_Train_page()
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
            var script = @"C:\Users\MSI MODERN\Desktop\python folder\python scripto\RNA model\training svm\train svm temp max.py";


            var train = txt_chemain_train.Text;
            var save = txt_save.Text;
            var to_pred = cbPrediction.SelectedItem.ToString();
            

            psi.Arguments = $"\"{script}\" \"{train}\" \"{save}\"\"{to_pred}\"";


            // 3) Process configuration
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = false;
            psi.RedirectStandardError = true;

            // 4) Execute process and get output


            var errors = "";
            var results = "";


            using(var process = Process.Start(psi))
            {
                errors = process.StandardError.ReadToEnd();
                results = process.StandardOutput.ReadToEnd();
            }


            // 5) Display output
            //Console.WriteLine("ERRORS:");
            //Console.WriteLine(errors);
            MessageBox.Show("Errors or warnings :" + errors);
            //Console.WriteLine();
            Console.WriteLine("Results:");
            Console.WriteLine(results);
            txt_result.Text = results;

           

        }

        private void button_parcourir_train_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\Users\MSI MODERN\Desktop\python folder\python scripto";
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            string train_file = openFileDialog1.FileName;
            txt_chemain_train.Text = train_file;
        }


        private void button_lunch_Click(object sender, EventArgs e)
        {
            
            python_script();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Learning_page retour3 = new Learning_page();
            retour3.Show();
            this.Hide();


        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Svm_Train_page_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            MessageBox.Show(cbPrediction.SelectedItem.ToString());
        }
    }
}
