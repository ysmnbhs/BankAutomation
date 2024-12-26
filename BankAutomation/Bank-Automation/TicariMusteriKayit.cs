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
    public partial class TicariMusteriKayit : Form
    {
        public Banka banka;
        public Musteri musteri = new Musteri();
        public TicariMusteri ticariMusteri = new TicariMusteri();
        public TicariMusteriKayit()
        {
            InitializeComponent();
        }

        private void hesapAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HesapAcma hesapAcma=new HesapAcma();
            hesapAcma.banka = this.banka;
            hesapAcma.musteri = this.ticariMusteri;
            hesapAcma.Show();
        }

        private void btnTicariKaydet_Click(object sender, EventArgs e)
        {
            Hesaplarım hesaplarım = new Hesaplarım();
            hesaplarım.musteri=this.ticariMusteri; 

            ticariMusteri.Kimlik.Ad = txtFirmaAdi.Text;
            ticariMusteri.SicilNumarasi = ticariMusteri.Kimlik.TCKimlikNo =  Convert.ToString(txtSicilNo.Text);
            banka.MusteriEkle(ticariMusteri);
            MessageBox.Show("Musteri tipi: Ticari\nFirma adi: " + ticariMusteri.Kimlik.Ad + "\nSicil numarasi: " + ticariMusteri.SicilNumarasi);

        }

        private void ticariMüşteriKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BireyselMusteriKayit bireyselMusteriKayit = new BireyselMusteriKayit();
            bireyselMusteriKayit.Show();    
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
