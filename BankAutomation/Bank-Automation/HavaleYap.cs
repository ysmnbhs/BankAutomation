using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Final_Projesi
{
    public partial class HavaleYap : Form
    {
        public Banka banka;
        public BankaHesabi gonderenHesap;
        public BankaHesabi alanHesap;
        public Musteri musteri;
        public HavaleYap()
        {
            InitializeComponent();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            Hesaplarım hesaplarım = new Hesaplarım();
            hesaplarım.banka = this.banka;
            int gonderilecekHesapNo = Convert.ToInt32(txtHavaleYapilacakHesapNo.Text);
            double havaleMiktari = 0.0;
            if (musteri.HesabiKontrolEt(gonderilecekHesapNo) != null)
            {
                havaleMiktari = Convert.ToDouble(txtHavaleMiktari.Text);
                gonderenHesap = musteri.HesabiKontrolEt(gonderilecekHesapNo);
                gonderenHesap.Bakiye = musteri.HesabiKontrolEt(gonderilecekHesapNo).Bakiye;
                alanHesap = musteri.HesabiKontrolEt(gonderilecekHesapNo);
                alanHesap.Bakiye = musteri.HesabiKontrolEt(gonderilecekHesapNo).Bakiye;

                musteri.HavaleYap(gonderenHesap, alanHesap, havaleMiktari);
                hesaplarım.musteri = this.musteri;
            }
            else
            {
                MessageBox.Show("Boyle bir musteri hesabi bulunmamaktadir. Lutfen tekrar deneyiniz");
            }
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
