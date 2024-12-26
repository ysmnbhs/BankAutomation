using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Final_Projesi
{
    public class BankaHesabi
    {
        public List<MusteriHesapOzeti> MusteriHesapOzetleri { get; set; }
        public string HesapSube { get; set; }
        public int HesapNo { get; private set; }
        public int Limit { get; set; }
        public double Bakiye { get; set; }
        public long EkHesapBakiyesi { get; set; }
        public BankaHesabi()
        {
            this.Bakiye = 0.0;
            this.Limit = 750;
            this.EkHesapBakiyesi = 500;
            Random random = new Random();
            this.HesapNo = random.Next(1, 50);
            this.MusteriHesapOzetleri = new List<MusteriHesapOzeti>();
        }
        public void HesapOzetiEkle(MusteriHesapOzeti hesapOzeti)
        {
            MusteriHesapOzetleri.Add(hesapOzeti);
        }
    }
}
