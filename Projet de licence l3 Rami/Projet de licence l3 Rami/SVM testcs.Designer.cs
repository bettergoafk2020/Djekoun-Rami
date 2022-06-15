namespace Projet_de_licence_l3_Rami
{
    partial class SVM_testcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_save = new System.Windows.Forms.Button();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.button_brows_model = new System.Windows.Forms.Button();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_parcourir_test = new System.Windows.Forms.Button();
            this.txt_chemain_test = new System.Windows.Forms.TextBox();
            this.button_lunch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_save
            // 
            this.button_save.Enabled = false;
            this.button_save.Location = new System.Drawing.Point(421, 435);
            this.button_save.Margin = new System.Windows.Forms.Padding(4);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(125, 28);
            this.button_save.TabIndex = 40;
            this.button_save.Text = "Save ";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(199, 187);
            this.txt_result.Margin = new System.Windows.Forms.Padding(4);
            this.txt_result.Multiline = true;
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(568, 240);
            this.txt_result.TabIndex = 39;
            // 
            // button_brows_model
            // 
            this.button_brows_model.Location = new System.Drawing.Point(669, 151);
            this.button_brows_model.Margin = new System.Windows.Forms.Padding(4);
            this.button_brows_model.Name = "button_brows_model";
            this.button_brows_model.Size = new System.Drawing.Size(100, 28);
            this.button_brows_model.TabIndex = 38;
            this.button_brows_model.Text = "Browse";
            this.button_brows_model.UseVisualStyleBackColor = true;
            this.button_brows_model.Click += new System.EventHandler(this.button_brows_model_Click);
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(199, 155);
            this.txt_model.Margin = new System.Windows.Forms.Padding(4);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(460, 22);
            this.txt_model.TabIndex = 37;
            this.txt_model.Text = "Model path";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 435);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 28);
            this.button1.TabIndex = 36;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_parcourir_test
            // 
            this.button_parcourir_test.Location = new System.Drawing.Point(669, 115);
            this.button_parcourir_test.Margin = new System.Windows.Forms.Padding(4);
            this.button_parcourir_test.Name = "button_parcourir_test";
            this.button_parcourir_test.Size = new System.Drawing.Size(100, 28);
            this.button_parcourir_test.TabIndex = 35;
            this.button_parcourir_test.Text = "Browse";
            this.button_parcourir_test.UseVisualStyleBackColor = true;
            this.button_parcourir_test.Click += new System.EventHandler(this.button_parcourir_test_Click);
            // 
            // txt_chemain_test
            // 
            this.txt_chemain_test.Location = new System.Drawing.Point(199, 119);
            this.txt_chemain_test.Margin = new System.Windows.Forms.Padding(4);
            this.txt_chemain_test.Name = "txt_chemain_test";
            this.txt_chemain_test.Size = new System.Drawing.Size(460, 22);
            this.txt_chemain_test.TabIndex = 34;
            this.txt_chemain_test.Text = "Csv file path";
            // 
            // button_lunch
            // 
            this.button_lunch.Location = new System.Drawing.Point(643, 435);
            this.button_lunch.Margin = new System.Windows.Forms.Padding(4);
            this.button_lunch.Name = "button_lunch";
            this.button_lunch.Size = new System.Drawing.Size(125, 28);
            this.button_lunch.TabIndex = 33;
            this.button_lunch.Text = "Lunch";
            this.button_lunch.UseVisualStyleBackColor = true;
            this.button_lunch.Click += new System.EventHandler(this.button_lunch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(179)))), ((int)(((byte)(218)))));
            this.label3.Location = new System.Drawing.Point(374, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 39);
            this.label3.TabIndex = 41;
            this.label3.Text = "Test with SVM";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Température Max (°c)    ",
            "Température Min (°c)",
            "Température Moy (°c)",
            "Humidité Moy (%)",
            "Vent Max (Km/h)",
            "Vent Moy(Km/h) ",
            "Visibilité moy (km)",
            "Precipitation (mm)"});
            this.checkedListBox1.Location = new System.Drawing.Point(838, 197);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(173, 157);
            this.checkedListBox1.TabIndex = 42;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(868, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 28);
            this.button2.TabIndex = 43;
            this.button2.Text = "file";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SVM_testcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projet_de_licence_l3_Rami.Properties.Resources.rna_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 495);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.button_brows_model);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_parcourir_test);
            this.Controls.Add(this.txt_chemain_test);
            this.Controls.Add(this.button_lunch);
            this.Name = "SVM_testcs";
            this.Text = "SVM_testcs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Button button_brows_model;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_parcourir_test;
        private System.Windows.Forms.TextBox txt_chemain_test;
        private System.Windows.Forms.Button button_lunch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button2;
    }
}