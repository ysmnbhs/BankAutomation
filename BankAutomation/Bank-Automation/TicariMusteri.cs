using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Final_Projesi
{
    public class TicariMusteri : Musteri
    {
        public string FirmaAdi { get; set; }
        public string SicilNumarasi { get; set; }
        public override void HavaleYap(BankaHesabi gonderenHesap, BankaHesabi alanHesap, double havaleMiktari)
        {
            //gonderenHesap.Bakiye -= havaleMiktari;
            alanHesap.Bakiye += havaleMiktari;

            MusteriHesapOzeti GonderenHesapHareketi = new MusteriHesapOzeti();
            GonderenHesapHareketi.YatirilanPara = 0;
            GonderenHesapHareketi.CekilenPara = havaleMiktari;
            GonderenHesapHareketi.TransferMi = true;
            GonderenHesapHareketi.IslemTarihi = DateTime.Now;
            gonderenHesap.HesapOzetiEkle(GonderenHesapHareketi);


            MusteriHesapOzeti AlanHesapHareketi = new MusteriHesapOzeti();
            AlanHesapHareketi.YatirilanPara = havaleMiktari;
            AlanHesapHareketi.CekilenPara = 0;
            AlanHesapHareketi.TransferMi = true;
            AlanHesapHareketi.IslemTarihi = DateTime.Now;
            alanHesap.HesapOzetiEkle(AlanHesapHareketi);

            MessageBox.Show("Havale işlemi basarili." + "\nGonderilen para: " +
                havaleMiktari.ToString() + "\nAlan hesabin bakiyesi: " + alanHesap.Bakiye.ToString());
        }
    }
}
