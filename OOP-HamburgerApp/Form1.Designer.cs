﻿namespace OOP_HamburgerApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            siparişYönetimiToolStripMenuItem = new ToolStripMenuItem();
            siparişOluşturToolStripMenuItem = new ToolStripMenuItem();
            siparişBilgileriToolStripMenuItem = new ToolStripMenuItem();
            menüYönetimiToolStripMenuItem = new ToolStripMenuItem();
            menüEkleToolStripMenuItem = new ToolStripMenuItem();
            ekstraMalzemeEkleToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { siparişYönetimiToolStripMenuItem, menüYönetimiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(552, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // siparişYönetimiToolStripMenuItem
            // 
            siparişYönetimiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { siparişOluşturToolStripMenuItem, siparişBilgileriToolStripMenuItem });
            siparişYönetimiToolStripMenuItem.Name = "siparişYönetimiToolStripMenuItem";
            siparişYönetimiToolStripMenuItem.Size = new Size(129, 24);
            siparişYönetimiToolStripMenuItem.Text = "Sipariş Yönetimi";
            // 
            // siparişOluşturToolStripMenuItem
            // 
            siparişOluşturToolStripMenuItem.Name = "siparişOluşturToolStripMenuItem";
            siparişOluşturToolStripMenuItem.Size = new Size(224, 26);
            siparişOluşturToolStripMenuItem.Text = "Sipariş Oluştur";
            siparişOluşturToolStripMenuItem.Click += siparişOluşturToolStripMenuItem_Click;
            // 
            // siparişBilgileriToolStripMenuItem
            // 
            siparişBilgileriToolStripMenuItem.Name = "siparişBilgileriToolStripMenuItem";
            siparişBilgileriToolStripMenuItem.Size = new Size(224, 26);
            siparişBilgileriToolStripMenuItem.Text = "Sipariş Bilgileri";
            siparişBilgileriToolStripMenuItem.Click += siparişBilgileriToolStripMenuItem_Click;
            // 
            // menüYönetimiToolStripMenuItem
            // 
            menüYönetimiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menüEkleToolStripMenuItem, ekstraMalzemeEkleToolStripMenuItem });
            menüYönetimiToolStripMenuItem.Name = "menüYönetimiToolStripMenuItem";
            menüYönetimiToolStripMenuItem.Size = new Size(122, 24);
            menüYönetimiToolStripMenuItem.Text = "Menü Yönetimi";
            // 
            // menüEkleToolStripMenuItem
            // 
            menüEkleToolStripMenuItem.Name = "menüEkleToolStripMenuItem";
            menüEkleToolStripMenuItem.Size = new Size(227, 26);
            menüEkleToolStripMenuItem.Text = "Menü Ekle";
            menüEkleToolStripMenuItem.Click += menüEkleToolStripMenuItem_Click;
            // 
            // ekstraMalzemeEkleToolStripMenuItem
            // 
            ekstraMalzemeEkleToolStripMenuItem.Name = "ekstraMalzemeEkleToolStripMenuItem";
            ekstraMalzemeEkleToolStripMenuItem.Size = new Size(227, 26);
            ekstraMalzemeEkleToolStripMenuItem.Text = "Ekstra Malzeme Ekle";
            ekstraMalzemeEkleToolStripMenuItem.Click += ekstraMalzemeEkleToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 439);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "AnaForrm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem siparişYönetimiToolStripMenuItem;
        private ToolStripMenuItem siparişOluşturToolStripMenuItem;
        private ToolStripMenuItem siparişBilgileriToolStripMenuItem;
        private ToolStripMenuItem menüYönetimiToolStripMenuItem;
        private ToolStripMenuItem menüEkleToolStripMenuItem;
        private ToolStripMenuItem ekstraMalzemeEkleToolStripMenuItem;
    }
}
