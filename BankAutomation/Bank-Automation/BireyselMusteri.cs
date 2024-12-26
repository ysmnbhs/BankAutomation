using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Final_Projesi
{
    public class BireyselMusteri : Musteri
    {
        public override void HavaleYap(BankaHesabi gonderenHesap, BankaHesabi alanHesap, double havaleMiktari)
        {
            base.HavaleUcreti = 0.0;
            HavaleUcreti = (havaleMiktari * 2) / 100;
            double eksilenPara = HavaleUcreti + havaleMiktari;
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

            MessageBox.Show("Havale işlemi basarili.\nBireysel musteri oldugunuz icin %2 havale ucreti kesilmistir." +
                "\nKesilen havale ucreti: " + HavaleUcreti+ "TL\nGonderilen para: " +
                eksilenPara.ToString() + "TL\nAlan hesabin bakiyesi: " + alanHesap.Bakiye.ToString());
        }
    }
}
