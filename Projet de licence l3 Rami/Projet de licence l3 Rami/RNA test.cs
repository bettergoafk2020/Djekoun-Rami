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
using System.IO;


namespace Projet_de_licence_l3_Rami
{
    public partial class RNA_test : Form
    {
        public RNA_test()
        {
            InitializeComponent();
        }

        private void button_parcourir_test_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\Users\MSI MODERN\Desktop\python folder\python scripto";
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            string test_file = openFileDialog1.FileName;
            txt_chemain_test.Text = test_file;
        }
        private void python_script()
        {

            // 1) Create Process Info
            var psi = new ProcessStartInfo();
            psi.FileName = @"C:\Users\MSI MODERN\AppData\Local\Programs\Python\Python39\python.exe";

            // 2) Provide script and arguments
            var script = @"C:\Users\MSI MODERN\Desktop\python folder\python scripto\RNA model\RNA model test.py";

            var test = txt_chemain_test.Text;



            psi.Arguments = $"\"{script}\" \"{test}\" \"{txt_model_json.Text}\" ";
            //psi.Arguments = $"\"{script}\" \"{train}\" \"{test}\"";


            // 3) Process configuration
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            // 4) Execute process and get output


            var errors = "";
            var results = "";



            using (var process = Process.Start(psi))
            {
                errors = process.StandardError.ReadToEnd();
                results = process.StandardOutput.ReadToEnd();
            }




            // 5) Display output
            //Console.WriteLine("ERRORS:");
            //Console.WriteLine(errors);
            MessageBox.Show("Errors or warnings :" + errors);
            //Console.WriteLine();
            //Console.WriteLine("Results:");
            //Console.WriteLine(results);
            txt_result.Text = results;




        }

        private void button_brows_model_json_Click(object sender, EventArgs e)
        {
            openFileDialog2.InitialDirectory = @"C:\Users\MSI MODERN\Desktop\python folder\python scripto";
            openFileDialog2.Filter = "All files (*.*)|*.*";
            openFileDialog2.ShowDialog();
            string model_path_json = openFileDialog2.FileName;
            txt_model_json.Text = model_path_json;
        }

        private void button_lunch_Click(object sender, EventArgs e)
        {
            python_script();
            button_save.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test retour2 = new Test();
            retour2.Show();
            this.Hide();
        }

        private void button_save_Click(object sender, EventArgs e)
        {

            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.FileName = ".sav";
            saveFileDialog1.DefaultExt = "sav";
            saveFileDialog1.Filter = "csv files (xlsx)|*.csv";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream file_stream = saveFileDialog1.OpenFile();
                StreamWriter sw = new StreamWriter(file_stream);

                sw.Write(txt_result.Text);

                sw.Close();
                file_stream.Close();


            }
        }

        private void txt_result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
