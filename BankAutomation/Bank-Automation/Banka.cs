using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Final_Projesi
{
    public class Banka
    {
        public List<Musteri> Musteriler { get; set; }
        public double ToplamPara { get; set; }
        public double ToplamYatirilanPara { get; set; }
        public double ToplamCekilenPara { get; set; }
        public Banka()
        {
            Musteriler = new List<Musteri>();
            this.ToplamPara = this.ToplamYatirilanPara - this.ToplamCekilenPara;
            this.ToplamCekilenPara = 0;
            this.ToplamYatirilanPara = 0;
        }
        public void MusteriEkle(Musteri EklenecekMusteri)
        {
            Musteriler.Add(EklenecekMusteri);
        }
        public void RaporSun(double toplamPara, double toplamYatirilanPara, double toplamCekilenPara)
        {
            this.ToplamCekilenPara = toplamCekilenPara;
            this.ToplamPara = toplamPara;
            this.ToplamYatirilanPara = toplamYatirilanPara;
        }

        public Musteri MusteriGirisiniKontrolEt(string MusteriTc)
        {
            foreach(Musteri musteri in this.Musteriler)
            {
                if(musteri.Kimlik.TCKimlikNo == MusteriTc)
                {
                    return musteri;
                }
            }
            return null;
        }
    }
}
