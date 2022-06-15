using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projet_de_licence_l3_Rami
{
    public partial class Data_Base : Form
    {
        SqlConnection s = new SqlConnection(@"Data Source=RAMI;Initial Catalog=Prediction;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da;
        DataSet ds;
        public Data_Base()
        {
            InitializeComponent();
        }
        DataTable T = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "")
            {
                MessageBox.Show("veuillez remplire tout les champs");
            }
            else
            {

                if (float.Parse(textBox3.Text) >= float.Parse(textBox2.Text))

                {

                    MessageBox.Show("la valeur de la temp min ne dépasse pas la valeur de temp max");

                }
                if (float.Parse(textBox4.Text) >= float.Parse(textBox2.Text))
                {

                    MessageBox.Show("La valeur de la temp moy ne dépasse pas la valeur de temp max ");

                }
                if (float.Parse(textBox3.Text) >= float.Parse(textBox4.Text))
                {

                    MessageBox.Show("La valeur de la temp min ne dépasse pas la valeur de temp moy");
                }

                else
                {

                    s.Open();

                    SqlCommand cmd2 = new SqlCommand("Select Datep from METEO where Datep=@Datep", s);
                    cmd2.Parameters.AddWithValue("@Datep", Convert.ToDateTime(textBox1.Text).ToString());
                    SqlDataReader dr = cmd2.ExecuteReader();
                    if (dr.Read())
                    {

                        s.Close();
                        MessageBox.Show("Duplicata de Date");

                    }

                    else
                    {
                        s.Close();
                    }



                    {
                        s.Open();



                        /*  SqlCommand cmd = new SqlCommand("insert into METEO (Datep,TempMax,TempMin,tempMoy,HumMoy,VentMax,VentMoy,Visibmoy,Precipitation)   Values ("+ textBox1.Text + " ," + textBox2.Text + "," + textBox3.Text + "," + textBox4.Text + "," + textBox5.Text + "," + textBox6.Text + "," + textBox7.Text + "," + textBox8.Text + "," + textBox9.Text + ")", s);                   */
                        SqlCommand cmd = new SqlCommand("insert into METEO  values (@Datep,@TempMax,@TempMin,@tempMoy,@HumMoy,@VentMax,@VentMoy,@Visibmoy,@Precipitation)", s);

                        cmd.Parameters.AddWithValue("@Datep", Convert.ToDateTime(textBox1.Text).ToString("dd/MM/yyyy"));
                        cmd.Parameters.AddWithValue("@TempMax", float.Parse(textBox2.Text));
                        cmd.Parameters.AddWithValue("@TempMin", float.Parse(textBox3.Text));
                        cmd.Parameters.AddWithValue("@tempMoy", float.Parse(textBox4.Text));
                        cmd.Parameters.AddWithValue("@HumMoy", float.Parse(textBox5.Text));
                        cmd.Parameters.AddWithValue("@VentMax", float.Parse(textBox6.Text));
                        cmd.Parameters.AddWithValue("@VentMoy", float.Parse(textBox7.Text));
                        cmd.Parameters.AddWithValue("@Visibmoy", float.Parse(textBox8.Text));
                        cmd.Parameters.AddWithValue("@Precipitation", float.Parse(textBox9.Text));


                        if (cmd.ExecuteNonQuery() == 1)
                        {

                            MessageBox.Show("Marrin enregistré !", "Succès");
                        }
                        else
                        {
                            MessageBox.Show("Marrin non enregistré !", "Echeque");
                        }
                        s.Close();
                    }
                }
            }
        }

        private void Data_Base_Load(object sender, EventArgs e)
        {
            /* try
             {
                 s.Open();
                 cmd.Connection = s;
                 cmd.CommandText = "select*from dbo.METEO";
                 SqlDataReader r = cmd.ExecuteReader();
                 while (r.Read())
                 {
                     dataGridView1.Rows.Add(r[0], r[1], r[2], r[3], r[4], r[5], r[6], r[7], r[8]);

                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
             finally
             {
                 s.Close();

             }*/
            da = new SqlDataAdapter("select * from METEO", s);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            s.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["Datep"].Value.ToString();
                textBox2.Text = row.Cells["TempMax"].Value.ToString();
                textBox3.Text = row.Cells["TempMin"].Value.ToString();
                textBox4.Text = row.Cells["tempMoy"].Value.ToString();
                textBox5.Text = row.Cells["HumMoy"].Value.ToString();
                textBox6.Text = row.Cells["VentMax"].Value.ToString();
                textBox7.Text = row.Cells["VentMoy"].Value.ToString();
                textBox8.Text = row.Cells["Visibmoy"].Value.ToString();
                textBox9.Text = row.Cells["Precipitation"].Value.ToString();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (float.Parse(textBox3.Text) >= float.Parse(textBox2.Text))

            {

                MessageBox.Show("la valeur de la temp min ne dépasse pas la valeur de temp max");

            }
            if (float.Parse(textBox4.Text) >= float.Parse(textBox2.Text))
            {

                MessageBox.Show("La valeur de la temp moy ne dépasse pas la valeur de temp max ");

            }
            if (float.Parse(textBox3.Text) >= float.Parse(textBox4.Text))
            {

                MessageBox.Show("La valeur de la temp min ne dépasse pas la valeur de temp moy");
            }
            else
            {
                s.Open();
                SqlCommand cmd = new SqlCommand("UPDATE METEO SET TempMax = @TempMax,TempMin=@TempMin,tempMoy=@tempMoy,HumMoy=@HumMoy,VentMax=@VentMax,VentMoy=@VentMoy,Visibmoy=@Visibmoy,Precipitation=@Precipitation  where  Datep=@Datep", s);

                cmd.Parameters.AddWithValue("@Datep", Convert.ToDateTime(textBox1.Text));
                cmd.Parameters.AddWithValue("@TempMax", float.Parse(textBox2.Text));
                cmd.Parameters.AddWithValue("@TempMin", float.Parse(textBox3.Text));
                cmd.Parameters.AddWithValue("@tempMoy", float.Parse(textBox4.Text));
                cmd.Parameters.AddWithValue("@HumMoy", float.Parse(textBox5.Text));
                cmd.Parameters.AddWithValue("@VentMax", float.Parse(textBox6.Text));
                cmd.Parameters.AddWithValue("@VentMoy", float.Parse(textBox7.Text));
                cmd.Parameters.AddWithValue("@Visibmoy", float.Parse(textBox8.Text));
                cmd.Parameters.AddWithValue("@Precipitation", float.Parse(textBox9.Text));
                if (cmd.ExecuteNonQuery() == 1)
                {

                    MessageBox.Show("Marrin modifié !", "Succès");
                }
                else
                {
                    MessageBox.Show("Marrin non modifié!", "Echeque");
                }
                s.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            s.Open();
            SqlCommand cmd = new SqlCommand("DELETE  METEO WHERE Datep=@Datep", s);
            cmd.Parameters.AddWithValue("@Datep", (textBox1.Text));
            cmd.ExecuteNonQuery();
            s.Close();
            MessageBox.Show("donnée supprimer ");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["Datep"].Value.ToString();
                textBox2.Text = row.Cells["TempMax"].Value.ToString();
                textBox3.Text = row.Cells["TempMin"].Value.ToString();
                textBox4.Text = row.Cells["tempMoy"].Value.ToString();
                textBox5.Text = row.Cells["HumMoy"].Value.ToString();
                textBox6.Text = row.Cells["VentMax"].Value.ToString();
                textBox7.Text = row.Cells["VentMoy"].Value.ToString();
                textBox8.Text = row.Cells["Visibmoy"].Value.ToString();
                textBox9.Text = row.Cells["Precipitation"].Value.ToString();


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Learning_page learning_Page = new Learning_page();
            learning_Page.Show();
            this.Hide();
        }
    }
}
