using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP_Final_Projesi
{
    public partial class Hesaplarım : Form
    {
        public Banka banka;
        public Musteri musteri;
        public BankaHesabi bankaHesabi;
        HesapAcma hesapAcma;
        public Hesaplarım()
        {
            InitializeComponent();
        }
        private void btnSeciliHesabaGec_Click(object sender, EventArgs e)
        {
            SeciliHesap seciliHesap = new SeciliHesap();
            HesapOzeti hesapOzeti = new HesapOzeti();
                            hesapOzeti.BankaHesabi = this.bankaHesabi;
            hesapOzeti.musteri = this.musteri;
            seciliHesap.banka = this.banka;
            seciliHesap.musteri = this.musteri;
            bankaHesabi = musteri.HesabiKontrolEt(hesapId);
            seciliHesap.bankaHesabi = this.bankaHesabi;
            seciliHesap.Show();
        }
        int hesapId;
        private void lvHesaplarım_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvHesaplarım.SelectedItems.Count > 0)
            {
                ListViewItem item = lvHesaplarım.SelectedItems[0];
                hesapId = Convert.ToInt32(item.SubItems[1].Text);
                MessageBox.Show(hesapId.ToString());
            }
        }

        private void Hesaplarım_Load(object sender, EventArgs e)
        {
            lvHesaplarım.Columns.Add("Hesabın Subesi", 100);
            lvHesaplarım.Columns.Add("Hesap No", 100);
            lvHesaplarım.Columns.Add("Bakiye", 100);

            foreach (BankaHesabi hesap in musteri.MusteriHesaplari)
            {
                string[] hesapBilgi = { hesap.HesapSube, hesap.HesapNo.ToString(), hesap.Bakiye.ToString() };
                ListViewItem item = new ListViewItem(hesapBilgi);
                lvHesaplarım.Items.Add(item);
            }
            txtHesabinSahibi.Text = (musteri.Kimlik.Ad + " " + musteri.Kimlik.Soyad).ToUpper();
        }

        private void btnYeniHesapAc_Click(object sender, EventArgs e)
        {
            hesapAcma = new HesapAcma();
            hesapAcma.Show();
        }
    }
}
