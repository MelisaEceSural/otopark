using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20181224_OOP_OtoPark
{
    public partial class RaporForm : Form
    {
        public RaporForm(object Liste)
        {
            InitializeComponent();
            this.aracListesi = (List<Arac>)Liste;
        }
        List<Arac> aracListesi;

        private void RaporForm_Load(object sender, EventArgs e)
        {
            decimal toplam = 0;
            foreach (Arac arac in aracListesi)
            {
                ListViewItem satir = new ListViewItem();//ListViewItem nesnesi ListView'ın satırlarıdır. Her araç için bir satır oluşturduk. //Plaka, marka, sinif, abone, sure, ucret

                //Satırın kolonlarını dolduruyoruz.
                satir.Text = arac.Plaka;
                satir.SubItems.Add(arac.Marka.ToString());
                satir.SubItems.Add(arac.Tipi.Sinifi.ToString());
                satir.SubItems.Add(arac.Abone == true ? "Abone" : "Değil");
                satir.SubItems.Add(arac.Sure.ToString() + " Saat");
                satir.SubItems.Add(arac.Ucret.ToString("C2"));
                toplam += arac.Ucret;
                //satır nesnesi dolduruldu, şimdi ListView'e ekliyoruz.
                listView1.Items.Add(satir);

            }

            lblAracSayisi.Text = aracListesi.Count + " Adet";
            lblKasa.Text = toplam.ToString("C2");

        }
    }
}
