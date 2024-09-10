using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hamburger
{
    public class Siparis
    {
        public Siparis()
        {
            EkstraMalzemeler = new List<EkstraMalzeme>();
        }
        public Menu SeciliMenu { get; set; }
        public Boyut Boyut { get; set; }
        public List<EkstraMalzeme> EkstraMalzemeler { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }


        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += SeciliMenu.Fiyati;
            switch (Boyut)
            {
                case Boyut.Orta:
                    ToplamTutar += ToplamTutar * 0.10M;
                    break;
                case Boyut.Büyük:
                    ToplamTutar += ToplamTutar * 0.25M;
                    break;
            }

            foreach (EkstraMalzeme ekstra in EkstraMalzemeler)
            {
                ToplamTutar += ekstra.Fiyati;
            }
            ToplamTutar *= Adet;
        }

        public override string ToString()
        {
            if (EkstraMalzemeler.Count < 1) //ekstra malzeme seçilmemişse
            {
                return string.Format("{0} Menü X {1} Adet, {2} Boy, Toplam {3}",SeciliMenu.Ad,Adet,Boyut,ToplamTutar.ToString("C2"));
            }
            else
            {
                string ekstraMalzemeler = string.Empty;
                foreach (EkstraMalzeme ekstra in EkstraMalzemeler)
                {
                    ekstraMalzemeler += ekstra.Ad + " ,";   //malzemelerin arasına ve sonuna virgün ekler
                }
               ekstraMalzemeler = ekstraMalzemeler.Trim(',');  //en sondaki virgülü siler çünkü tostring içerisinde de bir virgül var .2 tane virgül görünümünü ortadan kaldırmak için trim ile sondaki virgülü kaldırdık.
                return string.Format("{0} Menü X {1} Adet, {2} Boy, {3} , Toplam {4}", SeciliMenu.Ad, Adet, Boyut,ekstraMalzemeler, ToplamTutar.ToString("C2"));
            }
        }
    }
}
