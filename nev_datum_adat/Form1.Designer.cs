namespace nev_datum_adat
{
    partial class Form1
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
            this.button_nyitas = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.label_nev = new System.Windows.Forms.Label();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.richTextBox_szoveg = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dateTimePicker_datum = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // button_nyitas
            // 
            this.button_nyitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_nyitas.Location = new System.Drawing.Point(435, 87);
            this.button_nyitas.Name = "button_nyitas";
            this.button_nyitas.Size = new System.Drawing.Size(163, 31);
            this.button_nyitas.TabIndex = 9;
            this.button_nyitas.Text = "Megnyitás";
            this.button_nyitas.UseVisualStyleBackColor = true;
            this.button_nyitas.Click += new System.EventHandler(this.button_nyitas_Click);
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_save.Location = new System.Drawing.Point(435, 40);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(163, 30);
            this.button_save.TabIndex = 8;
            this.button_save.Text = "Mentés";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label_nev
            // 
            this.label_nev.AutoSize = true;
            this.label_nev.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_nev.Location = new System.Drawing.Point(28, 43);
            this.label_nev.Name = "label_nev";
            this.label_nev.Size = new System.Drawing.Size(56, 25);
            this.label_nev.TabIndex = 7;
            this.label_nev.Text = "Név:";
            // 
            // textBox_nev
            // 
            this.textBox_nev.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_nev.Location = new System.Drawing.Point(152, 40);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(247, 31);
            this.textBox_nev.TabIndex = 6;
            // 
            // richTextBox_szoveg
            // 
            this.richTextBox_szoveg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox_szoveg.Location = new System.Drawing.Point(0, 209);
            this.richTextBox_szoveg.Name = "richTextBox_szoveg";
            this.richTextBox_szoveg.Size = new System.Drawing.Size(800, 241);
            this.richTextBox_szoveg.TabIndex = 5;
            this.richTextBox_szoveg.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(28, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Dátum:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dateTimePicker_datum
            // 
            this.dateTimePicker_datum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker_datum.Location = new System.Drawing.Point(152, 85);
            this.dateTimePicker_datum.Name = "dateTimePicker_datum";
            this.dateTimePicker_datum.Size = new System.Drawing.Size(247, 31);
            this.dateTimePicker_datum.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker_datum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_nyitas);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label_nev);
            this.Controls.Add(this.textBox_nev);
            this.Controls.Add(this.richTextBox_szoveg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_nyitas;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label_nev;
        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.RichTextBox richTextBox_szoveg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_datum;
    }
}

