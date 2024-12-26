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
    public partial class BireyselMusteriKayit : Form
    {
        public Banka banka;
        public BireyselMusteri bireyselMusteri = new BireyselMusteri();
        public BireyselMusteriKayit()
        {
            InitializeComponent();
        }

        private void hesapAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HesapAcma hesapAcma = new HesapAcma();
            HesapOzeti hesapOzeti = new HesapOzeti();
            hesapAcma.banka = this.banka;
            hesapOzeti.musteri = this.bireyselMusteri;
            hesapAcma.musteri = this.bireyselMusteri;
            hesapAcma.Show();
        }

        private void btnBireyselKaydet_Click(object sender, EventArgs e)
        {
            Hesaplarım hesaplarım = new Hesaplarım();
            hesaplarım.musteri = bireyselMusteri;
            GirisYap girisYap = new GirisYap();
            girisYap.banka = this.banka;

            bireyselMusteri.Kimlik.Ad = txtAd.Text;
            bireyselMusteri.Kimlik.Soyad = txtSoyad.Text;
            bireyselMusteri.Kimlik.TCKimlikNo = txtTC.Text;
            banka.MusteriEkle(bireyselMusteri);
            MessageBox.Show("Musteri tipi: Bireysel\nAdi soyadi: " + bireyselMusteri.Kimlik.Ad + " "+ bireyselMusteri.Kimlik.Soyad + "\nTC'si: " + bireyselMusteri.Kimlik.TCKimlikNo);
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
