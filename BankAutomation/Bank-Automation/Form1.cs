namespace OOP_Final_Projesi
{
    public partial class Form1 : Form
    {
        public Banka banka = new Banka();
        public Form1()
        {
            InitializeComponent();
        }

        private void bireyselToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BireyselMusteriKayit bireyselMusteriKayit = new BireyselMusteriKayit();
            bireyselMusteriKayit.banka = this.banka;
            bireyselMusteriKayit.Show();
        }

        private void ticariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicariMusteriKayit ticariMusteriKayit = new TicariMusteriKayit();
            ticariMusteriKayit.banka = this.banka;
            ticariMusteriKayit.Show();
        }

        private void girişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GirisYap GirisYap = new GirisYap();
            GirisYap.banka = this.banka;
            GirisYap.Show();
        }
    }
}