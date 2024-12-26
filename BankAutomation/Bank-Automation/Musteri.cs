using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Final_Projesi
{
    public class Musteri : Kisi
    {
        public List<BankaHesabi> MusteriHesaplari { get; set; }
        public int MusteriNo { get; set; }
        public double HavaleUcreti { get; set; }
        public string MusteriTipi { get; set; }
        public Musteri()
        {
            MusteriHesaplari = new List<BankaHesabi>();
            Random random = new Random();
            this.MusteriNo = random.Next(99);
        }

        public void HesapAc(BankaHesabi Hesap)
        {
            MusteriHesaplari.Add(Hesap);
        }

        public void HesapKapa(BankaHesabi Hesap)
        {
            MusteriHesaplari.Remove(Hesap);
        }

        public void ParaCek(BankaHesabi paraCekilecekHesap, long cekilecekTutar)
        {
            if (cekilecekTutar <= paraCekilecekHesap.Bakiye) 
            {
                if(cekilecekTutar <= 750)
                {
                    paraCekilecekHesap.Bakiye -= cekilecekTutar;

                    MusteriHesapOzeti hesapHareketi = new MusteriHesapOzeti();
                    hesapHareketi.BankaMusterisi = this;
                    hesapHareketi.YatirilanPara = 0;
                    hesapHareketi.CekilenPara = cekilecekTutar;
                    hesapHareketi.TransferMi = false;
                    hesapHareketi.IslemTarihi = DateTime.Now;

                    paraCekilecekHesap.HesapOzetiEkle(hesapHareketi);
                }
                else
                {
                    MessageBox.Show("750TL'nin uzerinde para cekemezsiniz!");
                }
            }

            else
            {
                MessageBox.Show("Yetersiz Bakiye! Ek hesabınıza yonlendiriliyorsunuz.");
                paraCekilecekHesap.EkHesapBakiyesi -= cekilecekTutar;
            }
        }

        public void ParaYatir(BankaHesabi paraYatirilacakHesap, long yatirilacakTutar)
        {
            paraYatirilacakHesap.Bakiye += yatirilacakTutar;

            MusteriHesapOzeti hesapHareketi = new MusteriHesapOzeti();
            hesapHareketi.BankaMusterisi = this;
            hesapHareketi.YatirilanPara = 0;
            hesapHareketi.CekilenPara = yatirilacakTutar;
            hesapHareketi.TransferMi = false;
            hesapHareketi.IslemTarihi = DateTime.Now;

            paraYatirilacakHesap.HesapOzetiEkle(hesapHareketi);
        }

        public BankaHesabi HesabiKontrolEt(int hesapNo)
        {
            foreach(BankaHesabi hesap in MusteriHesaplari)
            {
                if(hesap.HesapNo == hesapNo)
                {
                    return hesap;
                }  
            }
            return null;
        }

        public virtual void HavaleYap(BankaHesabi gonderenHesap, BankaHesabi alanHesap, double havaleMiktari)
        {
            this.HavaleUcreti = 0;
        }
    }
}
