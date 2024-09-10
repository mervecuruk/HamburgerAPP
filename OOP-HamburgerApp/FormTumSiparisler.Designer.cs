namespace OOP_HamburgerApp
{
    partial class FormTumSiparisler
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
            lstTumSiparisler = new ListBox();
            label1 = new Label();
            grbCiro = new GroupBox();
            lblCiro = new Label();
            grpToplamSiparisSayisi = new GroupBox();
            lblToplamSiparisSayisi = new Label();
            grpEkstraMalzemeGeliri = new GroupBox();
            lblEkstraGeliri = new Label();
            grpSatilanUrunAdeti = new GroupBox();
            lblSatilanUrunAdeti = new Label();
            grbCiro.SuspendLayout();
            grpToplamSiparisSayisi.SuspendLayout();
            grpEkstraMalzemeGeliri.SuspendLayout();
            grpSatilanUrunAdeti.SuspendLayout();
            SuspendLayout();
            // 
            // lstTumSiparisler
            // 
            lstTumSiparisler.FormattingEnabled = true;
            lstTumSiparisler.ItemHeight = 20;
            lstTumSiparisler.Location = new Point(12, 53);
            lstTumSiparisler.Name = "lstTumSiparisler";
            lstTumSiparisler.Size = new Size(193, 384);
            lstTumSiparisler.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 19);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 1;
            label1.Text = "TÜM SİPARİŞLER";
            // 
            // grbCiro
            // 
            grbCiro.Controls.Add(lblCiro);
            grbCiro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grbCiro.Location = new Point(222, 52);
            grbCiro.Name = "grbCiro";
            grbCiro.Size = new Size(185, 89);
            grbCiro.TabIndex = 2;
            grbCiro.TabStop = false;
            grbCiro.Text = "Ciro";
            // 
            // lblCiro
            // 
            lblCiro.AutoSize = true;
            lblCiro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCiro.ForeColor = Color.Red;
            lblCiro.Location = new Point(17, 35);
            lblCiro.Name = "lblCiro";
            lblCiro.Size = new Size(18, 20);
            lblCiro.TabIndex = 1;
            lblCiro.Text = "0";
            // 
            // grpToplamSiparisSayisi
            // 
            grpToplamSiparisSayisi.Controls.Add(lblToplamSiparisSayisi);
            grpToplamSiparisSayisi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grpToplamSiparisSayisi.Location = new Point(222, 172);
            grpToplamSiparisSayisi.Name = "grpToplamSiparisSayisi";
            grpToplamSiparisSayisi.Size = new Size(185, 87);
            grpToplamSiparisSayisi.TabIndex = 2;
            grpToplamSiparisSayisi.TabStop = false;
            grpToplamSiparisSayisi.Text = "Toplam Sipariş Sayısı";
            // 
            // lblToplamSiparisSayisi
            // 
            lblToplamSiparisSayisi.AutoSize = true;
            lblToplamSiparisSayisi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplamSiparisSayisi.ForeColor = Color.Red;
            lblToplamSiparisSayisi.Location = new Point(17, 40);
            lblToplamSiparisSayisi.Name = "lblToplamSiparisSayisi";
            lblToplamSiparisSayisi.Size = new Size(18, 20);
            lblToplamSiparisSayisi.TabIndex = 1;
            lblToplamSiparisSayisi.Text = "0";
            // 
            // grpEkstraMalzemeGeliri
            // 
            grpEkstraMalzemeGeliri.Controls.Add(lblEkstraGeliri);
            grpEkstraMalzemeGeliri.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grpEkstraMalzemeGeliri.Location = new Point(222, 292);
            grpEkstraMalzemeGeliri.Name = "grpEkstraMalzemeGeliri";
            grpEkstraMalzemeGeliri.Size = new Size(185, 88);
            grpEkstraMalzemeGeliri.TabIndex = 2;
            grpEkstraMalzemeGeliri.TabStop = false;
            grpEkstraMalzemeGeliri.Text = "Ekstra Malzeme Geliri";
            // 
            // lblEkstraGeliri
            // 
            lblEkstraGeliri.AutoSize = true;
            lblEkstraGeliri.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEkstraGeliri.ForeColor = Color.Red;
            lblEkstraGeliri.Location = new Point(17, 41);
            lblEkstraGeliri.Name = "lblEkstraGeliri";
            lblEkstraGeliri.Size = new Size(18, 20);
            lblEkstraGeliri.TabIndex = 1;
            lblEkstraGeliri.Text = "0";
            // 
            // grpSatilanUrunAdeti
            // 
            grpSatilanUrunAdeti.Controls.Add(lblSatilanUrunAdeti);
            grpSatilanUrunAdeti.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grpSatilanUrunAdeti.Location = new Point(222, 404);
            grpSatilanUrunAdeti.Name = "grpSatilanUrunAdeti";
            grpSatilanUrunAdeti.Size = new Size(185, 88);
            grpSatilanUrunAdeti.TabIndex = 2;
            grpSatilanUrunAdeti.TabStop = false;
            grpSatilanUrunAdeti.Text = "Satılan Ürün Adeti";
            // 
            // lblSatilanUrunAdeti
            // 
            lblSatilanUrunAdeti.AutoSize = true;
            lblSatilanUrunAdeti.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSatilanUrunAdeti.ForeColor = Color.Red;
            lblSatilanUrunAdeti.Location = new Point(17, 41);
            lblSatilanUrunAdeti.Name = "lblSatilanUrunAdeti";
            lblSatilanUrunAdeti.Size = new Size(18, 20);
            lblSatilanUrunAdeti.TabIndex = 1;
            lblSatilanUrunAdeti.Text = "0";
            // 
            // FormTumSiparisler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(430, 517);
            Controls.Add(grpSatilanUrunAdeti);
            Controls.Add(grpEkstraMalzemeGeliri);
            Controls.Add(grpToplamSiparisSayisi);
            Controls.Add(grbCiro);
            Controls.Add(label1);
            Controls.Add(lstTumSiparisler);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTumSiparisler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTumSiparisler";
            Load += FormTumSiparisler_Load;
            grbCiro.ResumeLayout(false);
            grbCiro.PerformLayout();
            grpToplamSiparisSayisi.ResumeLayout(false);
            grpToplamSiparisSayisi.PerformLayout();
            grpEkstraMalzemeGeliri.ResumeLayout(false);
            grpEkstraMalzemeGeliri.PerformLayout();
            grpSatilanUrunAdeti.ResumeLayout(false);
            grpSatilanUrunAdeti.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstTumSiparisler;
        private Label label1;
        private GroupBox grbCiro;
        private Label lblCiro;
        private GroupBox grpToplamSiparisSayisi;
        private Label lblToplamSiparisSayisi;
        private GroupBox grpEkstraMalzemeGeliri;
        private Label lblEkstraGeliri;
        private GroupBox grpSatilanUrunAdeti;
        private Label lblSatilanUrunAdeti;
    }
}