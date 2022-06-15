namespace Projet_de_licence_l3_Rami
{
    partial class Svm_Train_page
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
            this.button_parcourir_train = new System.Windows.Forms.Button();
            this.txt_chemain_train = new System.Windows.Forms.TextBox();
            this.txt_save = new System.Windows.Forms.TextBox();
            this.button_brows_save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.cbPrediction = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button_lunch
            // 
            this.button_lunch.Location = new System.Drawing.Point(636, 502);
            this.button_lunch.Margin = new System.Windows.Forms.Padding(4);
            this.button_lunch.Name = "button_lunch";
            this.button_lunch.Size = new System.Drawing.Size(125, 28);
            this.button_lunch.TabIndex = 62;
            this.button_lunch.Text = "Lunch";
            this.button_lunch.UseVisualStyleBackColor = true;
            this.button_lunch.Click += new System.EventHandler(this.button_lunch_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 512);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 28);
            this.button1.TabIndex = 61;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(193, 254);
            this.txt_result.Margin = new System.Windows.Forms.Padding(4);
            this.txt_result.Multiline = true;
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(568, 240);
            this.txt_result.TabIndex = 60;
            // 
            // button_parcourir_train
            // 
            this.button_parcourir_train.Location = new System.Drawing.Point(684, 191);
            this.button_parcourir_train.Margin = new System.Windows.Forms.Padding(4);
            this.button_parcourir_train.Name = "button_parcourir_train";
            this.button_parcourir_train.Size = new System.Drawing.Size(100, 28);
            this.button_parcourir_train.TabIndex = 57;
            this.button_parcourir_train.Text = "Browse";
            this.button_parcourir_train.UseVisualStyleBackColor = true;
            this.button_parcourir_train.Click += new System.EventHandler(this.button_parcourir_train_Click);
            // 
            // txt_chemain_train
            // 
            this.txt_chemain_train.Location = new System.Drawing.Point(207, 191);
            this.txt_chemain_train.Margin = new System.Windows.Forms.Padding(4);
            this.txt_chemain_train.Name = "txt_chemain_train";
            this.txt_chemain_train.Size = new System.Drawing.Size(460, 22);
            this.txt_chemain_train.TabIndex = 56;
            this.txt_chemain_train.Text = "Csv train file";
            // 
            // txt_save
            // 
            this.txt_save.Location = new System.Drawing.Point(207, 132);
            this.txt_save.Margin = new System.Windows.Forms.Padding(4);
            this.txt_save.Name = "txt_save";
            this.txt_save.Size = new System.Drawing.Size(460, 22);
            this.txt_save.TabIndex = 55;
            this.txt_save.Text = "Model registration folder";
            // 
            // button_brows_save
            // 
            this.button_brows_save.Location = new System.Drawing.Point(684, 132);
            this.button_brows_save.Margin = new System.Windows.Forms.Padding(4);
            this.button_brows_save.Name = "button_brows_save";
            this.button_brows_save.Size = new System.Drawing.Size(100, 28);
            this.button_brows_save.TabIndex = 54;
            this.button_brows_save.Text = "Browse";
            this.button_brows_save.UseVisualStyleBackColor = true;
            this.button_brows_save.Click += new System.EventHandler(this.button_brows_save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(179)))), ((int)(((byte)(218)))));
            this.label3.Location = new System.Drawing.Point(267, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 39);
            this.label3.TabIndex = 63;
            this.label3.Text = "train the SVM model";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // cbPrediction
            // 
            this.cbPrediction.FormattingEnabled = true;
            this.cbPrediction.Items.AddRange(new object[] {
            "Température Max (°c)",
            "Température Min (°c)",
            "température Moy (°c)  ",
            "Humidité Moy (%)",
            "Vent Max (Km/h)",
            "Vent Moy(Km/h)",
            "Visibilité moy (km)",
            "Precipitation (mm)"});
            this.cbPrediction.Location = new System.Drawing.Point(815, 189);
            this.cbPrediction.Name = "cbPrediction";
            this.cbPrediction.Size = new System.Drawing.Size(121, 24);
            this.cbPrediction.TabIndex = 64;
            this.cbPrediction.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // Svm_Train_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projet_de_licence_l3_Rami.Properties.Resources.rna_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1011, 565);
            this.Controls.Add(this.cbPrediction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_lunch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.button_parcourir_train);
            this.Controls.Add(this.txt_chemain_train);
            this.Controls.Add(this.txt_save);
            this.Controls.Add(this.button_brows_save);
            this.Name = "Svm_Train_page";
            this.Text = "Svm_Train_page";
            this.Load += new System.EventHandler(this.Svm_Train_page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_lunch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Button button_parcourir_train;
        private System.Windows.Forms.TextBox txt_chemain_train;
        private System.Windows.Forms.TextBox txt_save;
        private System.Windows.Forms.Button button_brows_save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.ComboBox cbPrediction;
    }
}