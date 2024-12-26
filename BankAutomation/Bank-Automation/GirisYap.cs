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
    public partial class GirisYap : Form
    {
        public Banka banka;
        public GirisYap()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
             if (banka.MusteriGirisiniKontrolEt(Convert.ToString(txtTc.Text)) != null)
            {
                Hesaplarım hesaplarım = new Hesaplarım();
                hesaplarım.banka = this.banka;
                hesaplarım.musteri = banka.MusteriGirisiniKontrolEt(Convert.ToString(txtTc.Text));
                MessageBox.Show("Giris basarili");
                hesaplarım.Show();
            }
            else
            {
                MessageBox.Show("Hatali kullanici!!");
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
