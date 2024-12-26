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
    public partial class SeciliHesap : Form
    {
        public Banka banka;
        public Musteri musteri;
        public BankaHesabi bankaHesabi;

        public SeciliHesap()
        {
            InitializeComponent();
        }

        private void btnHavaleYap_Click(object sender, EventArgs e)
        {
            HavaleYap havaleYap = new HavaleYap();
            havaleYap.banka = this.banka;
            havaleYap.musteri = this.musteri;
            havaleYap.gonderenHesap = this.bankaHesabi;
            havaleYap.Show();
            this.Close();
        }

        private void btnÖzet_Click(object sender, EventArgs e)
        {
            HesapOzeti hesapOzeti = new HesapOzeti();
            hesapOzeti.BankaHesabi = this.bankaHesabi;
            hesapOzeti.Show();
            this.Close();
        }

        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            long tutar = 0;
            tutar = Convert.ToInt64(txtTutar.Text);
            if(tutar != 0)
            {
                musteri.ParaYatir(bankaHesabi, tutar);
                txtSeciliHesapBakiye.Text = Convert.ToString(bankaHesabi.Bakiye);
            }
            else
            {
                MessageBox.Show("Yatirilacak para miktarini bos birakmayiniz!!");
            }
        }

        private void SeciliHesap_Load(object sender, EventArgs e)
        {
            txtSeciliHesapNo.Text = bankaHesabi.HesapNo.ToString();
            txtSeciliHesapBakiye.Text = bankaHesabi.Bakiye.ToString();
        }

        private void btnParaCek_Click(object sender, EventArgs e)
        {
            long tutar = 0;
            tutar = Convert.ToInt64(txtTutar.Text);
            if(tutar != 0)
            {
                musteri.ParaCek(bankaHesabi, tutar);
                txtSeciliHesapBakiye.Text = Convert.ToString(bankaHesabi.Bakiye);
            }
            else
            {
                MessageBox.Show("Lutfen cekilecek para miktarini bos birakmayiniz!!");
            }
        }
    }
}
