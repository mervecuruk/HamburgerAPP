using OOP_Hamburger;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HamburgerApp
{
    public static class Fonksiyonlar
    {
        //control.controlcollection:

        //Bir formdaki tüm denetimlerin üzerinde işlem yapmak için kullanılan bir koleksiyon sınıfıdır.
        //bu koleksiyon sınıfı içindeki denetimlerin farklı türlerine göre temizleme vs. işlemlerini yapar
        // bir Windows Forms formunun içindeki tüm butonlar, metin kutuları, etiketler vb.gibi denetimler bu koleksiyon içinde olabilir
        public static void Temizle(Control.ControlCollection kontroller)
        {
            foreach (Control kontrol in kontroller)
            {
                if (kontrol is ComboBox)
                {
                    ((ComboBox)kontrol).SelectedIndex = 0;
                }
                else if (kontrol is NumericUpDown)
                {
                    ((NumericUpDown)kontrol).Value = ((NumericUpDown)kontrol).Minimum;
                }
                else if (kontrol is RadioButton)
                {
                    RadioButton rb = (RadioButton)kontrol;
                    if (rb.Name == "rdbKucuk")
                        rb.Checked = true;
                    else
                        rb.Checked = false;
                }
                else if (kontrol is CheckBox)
                {
                    ((CheckBox)kontrol).Checked = false;
                }
                else if (kontrol is TextBox)
                {
                    ((TextBox)kontrol).Clear();
                }

                else if(kontrol is GroupBox)
                {
                    Temizle(((GroupBox)kontrol).Controls);
                }
                else if(kontrol is FlowLayoutPanel)
                {
                    Temizle(((FlowLayoutPanel)kontrol).Controls);

                }

            }
        }
    }
}

