namespace OOP_HamburgerApp
{
    partial class FormEkstra
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
            groupBox1 = new GroupBox();
            btnMalzemeEkle = new Button();
            nmrMalzemeFiyati = new NumericUpDown();
            txtMalzemeAdi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrMalzemeFiyati).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MistyRose;
            groupBox1.Controls.Add(btnMalzemeEkle);
            groupBox1.Controls.Add(nmrMalzemeFiyati);
            groupBox1.Controls.Add(txtMalzemeAdi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(290, 240);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "EKSTRA MALZEME BİLGİSİ";
            // 
            // btnMalzemeEkle
            // 
            btnMalzemeEkle.BackColor = Color.OliveDrab;
            btnMalzemeEkle.Location = new Point(32, 163);
            btnMalzemeEkle.Name = "btnMalzemeEkle";
            btnMalzemeEkle.Size = new Size(230, 49);
            btnMalzemeEkle.TabIndex = 3;
            btnMalzemeEkle.Text = "Ekstra Malzemeyi Kaydet";
            btnMalzemeEkle.UseVisualStyleBackColor = false;
            btnMalzemeEkle.Click += btnMalzemeEkle_Click;
            // 
            // nmrMalzemeFiyati
            // 
            nmrMalzemeFiyati.Location = new Point(171, 107);
            nmrMalzemeFiyati.Name = "nmrMalzemeFiyati";
            nmrMalzemeFiyati.Size = new Size(91, 27);
            nmrMalzemeFiyati.TabIndex = 2;
            // 
            // txtMalzemeAdi
            // 
            txtMalzemeAdi.Location = new Point(171, 44);
            txtMalzemeAdi.Name = "txtMalzemeAdi";
            txtMalzemeAdi.Size = new Size(91, 27);
            txtMalzemeAdi.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 107);
            label2.Name = "label2";
            label2.Size = new Size(45, 19);
            label2.TabIndex = 0;
            label2.Text = "Fiyat:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 52);
            label1.Name = "label1";
            label1.Size = new Size(145, 19);
            label1.TabIndex = 0;
            label1.Text = "Ekstra Malzeme Adı:";
            // 
            // FormEkstra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 269);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEkstra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEkstra";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrMalzemeFiyati).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtMalzemeAdi;
        private Label label1;
        private Button btnMalzemeEkle;
        private NumericUpDown nmrMalzemeFiyati;
        private Label label2;
    }
}