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
    public partial class SVM_testcs : Form
    {
        public SVM_testcs()
        {
            InitializeComponent();
        }

        private void button_parcourir_test_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\Users\MSI MODERN\Desktop\python folder\python scripto\test svm\test svm temp max.py";
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            string test_file = openFileDialog2.FileName;
            txt_chemain_test.Text = test_file;

        }
        private void python_script()
        {

            // 1) Create Process Info
            var psi = new ProcessStartInfo();
            psi.FileName = @"C:\Users\MSI MODERN\AppData\Local\Programs\Python\Python39\python.exe";

            // 2) Provide script and arguments
            var script = @"C:\Users\MSI MODERN\Desktop\python folder\python scripto\RNA model\training svm\train svm temp max.";

            var test = txt_chemain_test.Text;

            psi.Arguments = $"\"{script}\" \"{test}\" \"{txt_model.Text}\"";


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

            //-------
            //DataTable table_ajout = new DataTable();
            //able_ajout = results;
            //-------



        }

        private void button_brows_model_Click(object sender, EventArgs e)
        {
            openFileDialog2.InitialDirectory = @"C:\Users\MSI MODERN\Desktop\python folder\python scripto\test svm\Tests";
            openFileDialog2.Filter = "All files (*.*)|*.*";
            openFileDialog2.ShowDialog();
            string model_path = openFileDialog1.FileName;
            txt_model.Text = model_path;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.FileName = ".csv";
            saveFileDialog1.DefaultExt = "csv";
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

        private void button_lunch_Click(object sender, EventArgs e)
        {
            python_script();
            button_save.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test retour3= new Test();
            retour3.Show();
            this.Hide();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
                
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {    //get selected index
            int index = checkedListBox1.SelectedIndex;
            //get the item count 
            int count  = checkedListBox1.Items.Count;
            for (int x = 0; x < count; x++)
            {
                //ignore  selected ckeckbox from the list  
                if (index != x)
                {
                    checkedListBox1.SetItemChecked(x, false);
                }
            }
            

        }
    }
}
