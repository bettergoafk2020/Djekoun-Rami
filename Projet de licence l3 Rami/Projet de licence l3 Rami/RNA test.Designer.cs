namespace Projet_de_licence_l3_Rami
{
    partial class RNA_test
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
            this.button_save = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.button_brows_model_json = new System.Windows.Forms.Button();
            this.button_parcourir_test = new System.Windows.Forms.Button();
            this.txt_model_json = new System.Windows.Forms.TextBox();
            this.txt_chemain_test = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_lunch
            // 
            this.button_lunch.Location = new System.Drawing.Point(665, 463);
            this.button_lunch.Margin = new System.Windows.Forms.Padding(4);
            this.button_lunch.Name = "button_lunch";
            this.button_lunch.Size = new System.Drawing.Size(125, 28);
            this.button_lunch.TabIndex = 42;
            this.button_lunch.Text = "Lunch";
            this.button_lunch.UseVisualStyleBackColor = true;
            this.button_lunch.Click += new System.EventHandler(this.button_lunch_Click);
            // 
            // button_save
            // 
            this.button_save.Enabled = false;
            this.button_save.Location = new System.Drawing.Point(450, 463);
            this.button_save.Margin = new System.Windows.Forms.Padding(4);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(125, 28);
            this.button_save.TabIndex = 41;
            this.button_save.Text = "Save ";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 463);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 28);
            this.button1.TabIndex = 40;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(222, 204);
            this.txt_result.Margin = new System.Windows.Forms.Padding(4);
            this.txt_result.Multiline = true;
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(568, 240);
            this.txt_result.TabIndex = 39;
            this.txt_result.TextChanged += new System.EventHandler(this.txt_result_TextChanged);
            // 
            // button_brows_model_json
            // 
            this.button_brows_model_json.Location = new System.Drawing.Point(690, 161);
            this.button_brows_model_json.Margin = new System.Windows.Forms.Padding(4);
            this.button_brows_model_json.Name = "button_brows_model_json";
            this.button_brows_model_json.Size = new System.Drawing.Size(100, 28);
            this.button_brows_model_json.TabIndex = 38;
            this.button_brows_model_json.Text = "Browse";
            this.button_brows_model_json.UseVisualStyleBackColor = true;
            this.button_brows_model_json.Click += new System.EventHandler(this.button_brows_model_json_Click);
            // 
            // button_parcourir_test
            // 
            this.button_parcourir_test.Location = new System.Drawing.Point(690, 110);
            this.button_parcourir_test.Margin = new System.Windows.Forms.Padding(4);
            this.button_parcourir_test.Name = "button_parcourir_test";
            this.button_parcourir_test.Size = new System.Drawing.Size(100, 28);
            this.button_parcourir_test.TabIndex = 37;
            this.button_parcourir_test.Text = "Browse";
            this.button_parcourir_test.UseVisualStyleBackColor = true;
            this.button_parcourir_test.Click += new System.EventHandler(this.button_parcourir_test_Click);
            // 
            // txt_model_json
            // 
            this.txt_model_json.Location = new System.Drawing.Point(222, 164);
            this.txt_model_json.Margin = new System.Windows.Forms.Padding(4);
            this.txt_model_json.Name = "txt_model_json";
            this.txt_model_json.Size = new System.Drawing.Size(460, 22);
            this.txt_model_json.TabIndex = 36;
            this.txt_model_json.Text = "Json model path ";
            // 
            // txt_chemain_test
            // 
            this.txt_chemain_test.Location = new System.Drawing.Point(222, 113);
            this.txt_chemain_test.Margin = new System.Windows.Forms.Padding(4);
            this.txt_chemain_test.Name = "txt_chemain_test";
            this.txt_chemain_test.Size = new System.Drawing.Size(460, 22);
            this.txt_chemain_test.TabIndex = 35;
            this.txt_chemain_test.Text = "Csv test file";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(179)))), ((int)(((byte)(218)))));
            this.label3.Location = new System.Drawing.Point(385, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 39);
            this.label3.TabIndex = 43;
            this.label3.Text = "Test with RNA";
            // 
            // RNA_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projet_de_licence_l3_Rami.Properties.Resources.rna_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1026, 522);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_lunch);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.button_brows_model_json);
            this.Controls.Add(this.button_parcourir_test);
            this.Controls.Add(this.txt_model_json);
            this.Controls.Add(this.txt_chemain_test);
            this.Name = "RNA_test";
            this.Text = "RNA_test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_lunch;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Button button_brows_model_json;
        private System.Windows.Forms.Button button_parcourir_test;
        private System.Windows.Forms.TextBox txt_model_json;
        private System.Windows.Forms.TextBox txt_chemain_test;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label3;
    }
}