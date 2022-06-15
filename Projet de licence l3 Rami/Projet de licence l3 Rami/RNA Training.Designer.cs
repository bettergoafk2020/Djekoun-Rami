namespace Projet_de_licence_l3_Rami
{
    partial class RNA_Training
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
            this.button_lunch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.button_brows_test = new System.Windows.Forms.Button();
            this.button_parcourir_train = new System.Windows.Forms.Button();
            this.button_brows_save = new System.Windows.Forms.Button();
            this.txt_test_chemain = new System.Windows.Forms.TextBox();
            this.txt_chemain_train = new System.Windows.Forms.TextBox();
            this.txt_save = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // button_lunch
            // 
            this.button_lunch.Location = new System.Drawing.Point(592, 470);
            this.button_lunch.Margin = new System.Windows.Forms.Padding(4);
            this.button_lunch.Name = "button_lunch";
            this.button_lunch.Size = new System.Drawing.Size(125, 28);
            this.button_lunch.TabIndex = 81;
            this.button_lunch.Text = "Lunch";
            this.button_lunch.UseVisualStyleBackColor = true;
            this.button_lunch.Click += new System.EventHandler(this.button_lunch_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 481);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 28);
            this.button1.TabIndex = 80;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_result
            // 
            this.txt_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_result.Location = new System.Drawing.Point(115, 219);
            this.txt_result.Margin = new System.Windows.Forms.Padding(4);
            this.txt_result.Multiline = true;
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(602, 254);
            this.txt_result.TabIndex = 79;
            this.txt_result.Text = "The result will be automatically saved in the folder defined above";
            // 
            // button_brows_test
            // 
            this.button_brows_test.Location = new System.Drawing.Point(617, 154);
            this.button_brows_test.Margin = new System.Windows.Forms.Padding(4);
            this.button_brows_test.Name = "button_brows_test";
            this.button_brows_test.Size = new System.Drawing.Size(100, 28);
            this.button_brows_test.TabIndex = 78;
            this.button_brows_test.Text = "Browse";
            this.button_brows_test.UseVisualStyleBackColor = true;
            this.button_brows_test.Click += new System.EventHandler(this.button_brows_test_Click);
            // 
            // button_parcourir_train
            // 
            this.button_parcourir_train.Location = new System.Drawing.Point(617, 98);
            this.button_parcourir_train.Margin = new System.Windows.Forms.Padding(4);
            this.button_parcourir_train.Name = "button_parcourir_train";
            this.button_parcourir_train.Size = new System.Drawing.Size(100, 28);
            this.button_parcourir_train.TabIndex = 77;
            this.button_parcourir_train.Text = "Browse";
            this.button_parcourir_train.UseVisualStyleBackColor = true;
            this.button_parcourir_train.Click += new System.EventHandler(this.button_parcourir_train_Click);
            // 
            // button_brows_save
            // 
            this.button_brows_save.Location = new System.Drawing.Point(617, 40);
            this.button_brows_save.Margin = new System.Windows.Forms.Padding(4);
            this.button_brows_save.Name = "button_brows_save";
            this.button_brows_save.Size = new System.Drawing.Size(100, 28);
            this.button_brows_save.TabIndex = 76;
            this.button_brows_save.Text = "Browse";
            this.button_brows_save.UseVisualStyleBackColor = true;
            this.button_brows_save.Click += new System.EventHandler(this.button_brows_save_Click);
            // 
            // txt_test_chemain
            // 
            this.txt_test_chemain.Location = new System.Drawing.Point(115, 160);
            this.txt_test_chemain.Margin = new System.Windows.Forms.Padding(4);
            this.txt_test_chemain.Name = "txt_test_chemain";
            this.txt_test_chemain.Size = new System.Drawing.Size(460, 22);
            this.txt_test_chemain.TabIndex = 75;
            this.txt_test_chemain.Text = "Csv test file";
            // 
            // txt_chemain_train
            // 
            this.txt_chemain_train.Location = new System.Drawing.Point(115, 98);
            this.txt_chemain_train.Margin = new System.Windows.Forms.Padding(4);
            this.txt_chemain_train.Name = "txt_chemain_train";
            this.txt_chemain_train.Size = new System.Drawing.Size(460, 22);
            this.txt_chemain_train.TabIndex = 74;
            this.txt_chemain_train.Text = "Csv train file";
            // 
            // txt_save
            // 
            this.txt_save.Location = new System.Drawing.Point(115, 41);
            this.txt_save.Margin = new System.Windows.Forms.Padding(4);
            this.txt_save.Name = "txt_save";
            this.txt_save.Size = new System.Drawing.Size(460, 22);
            this.txt_save.TabIndex = 73;
            this.txt_save.Text = "Model registration folder";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // RNA_Training
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projet_de_licence_l3_Rami.Properties.Resources.rna_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(959, 523);
            this.Controls.Add(this.button_lunch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.button_brows_test);
            this.Controls.Add(this.button_parcourir_train);
            this.Controls.Add(this.button_brows_save);
            this.Controls.Add(this.txt_test_chemain);
            this.Controls.Add(this.txt_chemain_train);
            this.Controls.Add(this.txt_save);
            this.Name = "RNA_Training";
            this.Text = "RNA_Training";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_lunch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Button button_brows_test;
        private System.Windows.Forms.Button button_parcourir_train;
        private System.Windows.Forms.Button button_brows_save;
        private System.Windows.Forms.TextBox txt_test_chemain;
        private System.Windows.Forms.TextBox txt_chemain_train;
        private System.Windows.Forms.TextBox txt_save;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}