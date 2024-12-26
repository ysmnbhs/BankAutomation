using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Final_Projesi
{
    public class MusteriHesapOzeti
    {
        public DateTime IslemTarihi { get; set; }
        public double YatirilanPara { get; set; }
        public double CekilenPara { get; set; }
        public Musteri BankaMusterisi { get; set; }
        public bool TransferMi { get; set; }
    }
}
