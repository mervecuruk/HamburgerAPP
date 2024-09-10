namespace OOP_HamburgerApp
{
    partial class FormMenu
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
            btnMenuEkle = new Button();
            nmrMenuFiyati = new NumericUpDown();
            txtMenuAdi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrMenuFiyati).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MistyRose;
            groupBox1.Controls.Add(btnMenuEkle);
            groupBox1.Controls.Add(nmrMenuFiyati);
            groupBox1.Controls.Add(txtMenuAdi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(290, 240);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "MENÜ  BİLGİLERİ";
            // 
            // btnMenuEkle
            // 
            btnMenuEkle.BackColor = Color.OliveDrab;
            btnMenuEkle.Location = new Point(32, 163);
            btnMenuEkle.Name = "btnMenuEkle";
            btnMenuEkle.Size = new Size(230, 49);
            btnMenuEkle.TabIndex = 3;
            btnMenuEkle.Text = "Menüyü Kaydet";
            btnMenuEkle.UseVisualStyleBackColor = false;
            btnMenuEkle.Click += btnMenuEkle_Click;
            // 
            // nmrMenuFiyati
            // 
            nmrMenuFiyati.Location = new Point(171, 107);
            nmrMenuFiyati.Name = "nmrMenuFiyati";
            nmrMenuFiyati.Size = new Size(91, 27);
            nmrMenuFiyati.TabIndex = 2;
            // 
            // txtMenuAdi
            // 
            txtMenuAdi.Location = new Point(171, 44);
            txtMenuAdi.Name = "txtMenuAdi";
            txtMenuAdi.Size = new Size(91, 27);
            txtMenuAdi.TabIndex = 1;
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
            label1.Size = new Size(77, 19);
            label1.TabIndex = 0;
            label1.Text = "Menü Adı:";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 265);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrMenuFiyati).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnMenuEkle;
        private NumericUpDown nmrMenuFiyati;
        private TextBox txtMenuAdi;
        private Label label2;
        private Label label1;
    }
}