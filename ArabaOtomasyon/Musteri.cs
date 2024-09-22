using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaOtomasyon
{
    // Müşteri sınıfı
   public class Musteri
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }

        public Musteri(string ad, string soyad, string telefon)
        {
            Ad = ad;
            Soyad = soyad;
            Telefon = telefon;
        }

        public void MusteriBilgileriGoster()
        {
            Console.WriteLine($"Müşteri: {Ad} {Soyad}, Telefon: {Telefon}");
        }
    }
}
