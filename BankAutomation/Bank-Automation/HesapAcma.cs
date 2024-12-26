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
    public partial class HesapAcma : Form
    {
        public Musteri musteri;
        public Banka banka;
        public HavaleYap havaleYap;

        public HesapAcma()
        {
            InitializeComponent();
        }

        private void btnHesapOlustur_Click(object sender, EventArgs e)
        {
            Hesaplarım hesaplarım = new Hesaplarım();
            HesapOzeti hesapOzeti = new HesapOzeti();
            GirisYap girisYap = new GirisYap();
            girisYap.banka = this.banka;
            hesaplarım.banka = this.banka;
            hesapOzeti.musteri = this.musteri;

            BankaHesabi bankaHesabi = new BankaHesabi();
            bankaHesabi.HesapSube = txtHesabinSubesi.Text;
            musteri.HesapAc(bankaHesabi);
            hesaplarım.musteri = this.musteri;
            hesaplarım.Show();
            this.Close();
        }

        private void ticariMüşteriKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
