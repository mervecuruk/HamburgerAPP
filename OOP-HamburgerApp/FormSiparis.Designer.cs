namespace OOP_HamburgerApp
{
    partial class FormSiparis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSiparis));
            pblogo = new PictureBox();
            label1 = new Label();
            cmbMenuler = new ComboBox();
            grpBoyut = new GroupBox();
            rdbOrta = new RadioButton();
            rdbBuyuk = new RadioButton();
            rdbKucuk = new RadioButton();
            label2 = new Label();
            flpEktraMalzemeler = new FlowLayoutPanel();
            label3 = new Label();
            nmrAdet = new NumericUpDown();
            btnSiparisEkle = new Button();
            lstSiparisler = new ListBox();
            label4 = new Label();
            lblToplamTutar = new Label();
            btnSiparisTamamla = new Button();
            ((System.ComponentModel.ISupportInitialize)pblogo).BeginInit();
            grpBoyut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrAdet).BeginInit();
            SuspendLayout();
            // 
            // pblogo
            // 
            pblogo.Image = (Image)resources.GetObject("pblogo.Image");
            pblogo.Location = new Point(12, 12);
            pblogo.Name = "pblogo";
            pblogo.Size = new Size(258, 161);
            pblogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pblogo.TabIndex = 0;
            pblogo.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkMagenta;
            label1.Location = new Point(59, 188);
            label1.Name = "label1";
            label1.Size = new Size(144, 25);
            label1.TabIndex = 1;
            label1.Text = "MENÜ SEÇİNİZ";
            // 
            // cmbMenuler
            // 
            cmbMenuler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMenuler.FormattingEnabled = true;
            cmbMenuler.ImeMode = ImeMode.NoControl;
            cmbMenuler.Location = new Point(12, 216);
            cmbMenuler.Name = "cmbMenuler";
            cmbMenuler.Size = new Size(258, 28);
            cmbMenuler.TabIndex = 2;
            // 
            // grpBoyut
            // 
            grpBoyut.BackColor = Color.Transparent;
            grpBoyut.Controls.Add(rdbOrta);
            grpBoyut.Controls.Add(rdbBuyuk);
            grpBoyut.Controls.Add(rdbKucuk);
            grpBoyut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grpBoyut.ForeColor = Color.SaddleBrown;
            grpBoyut.Location = new Point(17, 276);
            grpBoyut.Name = "grpBoyut";
            grpBoyut.Size = new Size(253, 108);
            grpBoyut.TabIndex = 3;
            grpBoyut.TabStop = false;
            grpBoyut.Text = "BOYUT SEÇİNİZ";
            // 
            // rdbOrta
            // 
            rdbOrta.AutoSize = true;
            rdbOrta.Location = new Point(92, 46);
            rdbOrta.Name = "rdbOrta";
            rdbOrta.Size = new Size(61, 24);
            rdbOrta.TabIndex = 0;
            rdbOrta.TabStop = true;
            rdbOrta.Text = "Orta";
            rdbOrta.UseVisualStyleBackColor = true;
            // 
            // rdbBuyuk
            // 
            rdbBuyuk.AutoSize = true;
            rdbBuyuk.Location = new Point(170, 46);
            rdbBuyuk.Name = "rdbBuyuk";
            rdbBuyuk.Size = new Size(74, 24);
            rdbBuyuk.TabIndex = 0;
            rdbBuyuk.TabStop = true;
            rdbBuyuk.Text = "Büyük";
            rdbBuyuk.UseVisualStyleBackColor = true;
            // 
            // rdbKucuk
            // 
            rdbKucuk.AutoSize = true;
            rdbKucuk.Location = new Point(13, 46);
            rdbKucuk.Name = "rdbKucuk";
            rdbKucuk.Size = new Size(73, 24);
            rdbKucuk.TabIndex = 0;
            rdbKucuk.TabStop = true;
            rdbKucuk.Text = "Küçük";
            rdbKucuk.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkOliveGreen;
            label2.Location = new Point(17, 403);
            label2.Name = "label2";
            label2.Size = new Size(253, 25);
            label2.TabIndex = 1;
            label2.Text = "EKSTRA MALZEMEYİ SEÇİNİZ ";
            // 
            // flpEktraMalzemeler
            // 
            flpEktraMalzemeler.Location = new Point(20, 431);
            flpEktraMalzemeler.Name = "flpEktraMalzemeler";
            flpEktraMalzemeler.Size = new Size(250, 125);
            flpEktraMalzemeler.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(99, 576);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 5;
            label3.Text = "ADET:";
            // 
            // nmrAdet
            // 
            nmrAdet.Location = new Point(187, 574);
            nmrAdet.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmrAdet.Name = "nmrAdet";
            nmrAdet.Size = new Size(83, 27);
            nmrAdet.TabIndex = 6;
            nmrAdet.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnSiparisEkle
            // 
            btnSiparisEkle.BackColor = Color.Linen;
            btnSiparisEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSiparisEkle.ForeColor = Color.Red;
            btnSiparisEkle.Location = new Point(20, 631);
            btnSiparisEkle.Name = "btnSiparisEkle";
            btnSiparisEkle.Size = new Size(250, 52);
            btnSiparisEkle.TabIndex = 7;
            btnSiparisEkle.Text = "SİPARİŞ EKLE";
            btnSiparisEkle.UseVisualStyleBackColor = false;
            btnSiparisEkle.Click += btnSiparisEkle_Click;
            // 
            // lstSiparisler
            // 
            lstSiparisler.FormattingEnabled = true;
            lstSiparisler.ItemHeight = 20;
            lstSiparisler.Location = new Point(339, 26);
            lstSiparisler.Name = "lstSiparisler";
            lstSiparisler.Size = new Size(601, 444);
            lstSiparisler.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(339, 515);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 5;
            label4.Text = "TOPLAM TUTAR:";
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplamTutar.ForeColor = Color.Red;
            lblToplamTutar.Location = new Point(391, 550);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(18, 20);
            lblToplamTutar.TabIndex = 5;
            lblToplamTutar.Text = "0";
            // 
            // btnSiparisTamamla
            // 
            btnSiparisTamamla.BackColor = Color.PaleTurquoise;
            btnSiparisTamamla.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSiparisTamamla.ForeColor = Color.MidnightBlue;
            btnSiparisTamamla.Location = new Point(545, 504);
            btnSiparisTamamla.Name = "btnSiparisTamamla";
            btnSiparisTamamla.Size = new Size(167, 52);
            btnSiparisTamamla.TabIndex = 7;
            btnSiparisTamamla.Text = "SİPARİŞİ TAMAMLA";
            btnSiparisTamamla.UseVisualStyleBackColor = false;
            btnSiparisTamamla.Click += btnSiparisTamamla_Click;
            // 
            // FormSiparis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 695);
            Controls.Add(lstSiparisler);
            Controls.Add(btnSiparisTamamla);
            Controls.Add(btnSiparisEkle);
            Controls.Add(nmrAdet);
            Controls.Add(lblToplamTutar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(flpEktraMalzemeler);
            Controls.Add(grpBoyut);
            Controls.Add(cmbMenuler);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pblogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSiparis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSiparis";
            Load += FormSiparis_Load;
            ((System.ComponentModel.ISupportInitialize)pblogo).EndInit();
            grpBoyut.ResumeLayout(false);
            grpBoyut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrAdet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pblogo;
        private Label label1;
        private ComboBox cmbMenuler;
        private GroupBox grpBoyut;
        private RadioButton rdbOrta;
        private RadioButton rdbBuyuk;
        private RadioButton rdbKucuk;
        private Label label2;
        private FlowLayoutPanel flpEktraMalzemeler;
        private Label label3;
        private NumericUpDown nmrAdet;
        private Button btnSiparisEkle;
        private ListBox lstSiparisler;
        private Label label4;
        private Label lblToplamTutar;
        private Button btnSiparisTamamla;
    }
}