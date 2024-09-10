using OOP_Hamburger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_HamburgerApp
{
    public partial class FormTumSiparisler : Form
    {
        public FormTumSiparisler()
        {
            InitializeComponent();
        }

        private void FormTumSiparisler_Load(object sender, EventArgs e)
        {
            decimal ciro = 0, ekstraMazelemGeliri = 0;
            int satisAdeti = 0;
            foreach (Siparis   siparis in FormSiparis.TumSiparisler)
            {
                lstTumSiparisler.Items.Add(siparis);
                ciro += siparis.ToplamTutar;
                foreach (EkstraMalzeme ekstra in siparis.EkstraMalzemeler)
                {
                    ekstraMazelemGeliri += ekstra.Fiyati;
                }
                satisAdeti += siparis.Adet;
            }
            lblCiro.Text = ciro.ToString("C2");
            lblToplamSiparisSayisi.Text=lstTumSiparisler.Items.Count.ToString();
            lblEkstraGeliri.Text = ekstraMazelemGeliri.ToString("C2");
            lblSatilanUrunAdeti.Text = satisAdeti.ToString();

        }
    }
}
