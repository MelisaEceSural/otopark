using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20181224_OOP_OtoPark
{
    class Arac
    {
        public Arac()
        {
            Giris = DateTime.Now;
        }
        public string Plaka { get; set; }
        public AracMarka Marka { get; set; }
        public AracTip Tipi { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public bool Abone { get; set; }
        public int Sure
        {
            get
            {
                TimeSpan zamansalFark = Cikis - Giris;
                //int saat = (int)zamansalFark.TotalHours;// 1 saat bekleyemem
                int saat = (int)zamansalFark.TotalSeconds/10;
                return saat;
            }
        }

        public decimal Ucret
        {
            get
            {
                decimal toplam = Tipi.BirimFiyat * Sure;
                if (Abone)
                    toplam *= 0.85m;
                return toplam + 5;
            }
        }

        public override string ToString()
        {
            return string.Format("{0,-13}{1,-13}{2,-10}{3,-10}{4}",Plaka,Marka,Tipi.Sinifi,Abone?"Abone":"Abone Değil",Giris.ToString("hh:mm:ss"));
        }

    }
    // otomobil 1,5, panelvan 1,75, minibus 2,kamyonet 2,5 , otobus 3, kamyon 3,75, tır 4 tl giris ucreti 5

    struct AracTip
    {
        public AracSinifi Sinifi { get; set; }
        public decimal BirimFiyat { get; set; }

        public static AracTip TipAl(AracSinifi snf)
        {
            AracTip tip = new AracTip();
            tip.Sinifi = snf;
            switch (snf)
            {
                case AracSinifi.Otomobil:
                    tip.BirimFiyat = 1.5m;
                    break;
                case AracSinifi.Panelvan:
                    tip.BirimFiyat = 1.75m;
                    break;
                case AracSinifi.Minibus:
                    tip.BirimFiyat = 2m;
                    break;
                case AracSinifi.Kamyonet:
                    tip.BirimFiyat = 2.5m;
                    break;
                case AracSinifi.Otobus:
                    tip.BirimFiyat = 3m;
                    break;
                case AracSinifi.Kamyon:
                    tip.BirimFiyat = 3.75m;
                    break;
                case AracSinifi.Tır:
                    tip.BirimFiyat = 4m;
                    break;             
            }

            return tip;
        }
    }
    enum AracMarka
    {
        Bmw, Mercedes, Audi, VolksWagen, Ford, Opel, Volvo, Skoda, Seat, Renault, Honda, Toyota, Nissan, Mazda, Hyundai, Citroen, Peugeot, Fiat, AlfaRomeo, Lancia, Dacia, Kia, Mitsibushi, Subaru, Tofaş, Suzuki, Tesla, Porsche
    }
    enum AracSinifi
    {
        Otomobil, Panelvan, Minibus, Kamyonet, Otobus, Kamyon, Tır
    }
    
}
