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
    public partial class HesapOzeti : Form
    {
        public HesapAcma Hesap;
        public BankaHesabi BankaHesabi;
        public MusteriHesapOzeti hesapozeti;
        public Musteri musteri;
        Form1 ilkForm;
        public HesapOzeti()
        {
            InitializeComponent();
        }

        private void HesapOzeti_Load(object sender, EventArgs e)
        {
            lvHesapOzeti.Columns.Add("Islem yapilan para miktari", 200);
            lvHesapOzeti.Columns.Add("Islem tarihi", 200);
            lvHesapOzeti.Columns.Add("Transfer mi", 100);
            lvHesapOzeti.Columns.Add("Hesabin sahibi", 200);
            lvHesapOzeti.Columns.Add("Hesap bakiyesi", 200);

            foreach (MusteriHesapOzeti ozet in BankaHesabi.MusteriHesapOzetleri)
            {
                string[] hesapOzeti = {ozet.CekilenPara.ToString() ,ozet.IslemTarihi.ToString(), ozet.TransferMi.ToString(),
                ozet.BankaMusterisi.Kimlik.Ad.ToString(), BankaHesabi.Bakiye.ToString()};
                ListViewItem item = new ListViewItem(hesapOzeti);
                lvHesapOzeti.Items.Add(item);
            }
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            ilkForm = new Form1();
            ilkForm.Show();
        }
    }
}
