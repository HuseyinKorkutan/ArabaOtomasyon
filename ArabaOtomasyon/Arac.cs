using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaOtomasyon
{
    // Temel Araç sınıfı
    public class Arac
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Yil { get; set; }
        public double Fiyat { get; set; }

        public Arac(string marka, string model, int yil, double fiyat)
        {
            Marka = marka;
            Model = model;
            Yil = yil;
            Fiyat = fiyat;
        }

        public virtual void BilgileriGoster()
        {
            Console.WriteLine($"Marka: {Marka}, Model: {Model}, Yıl: {Yil}, Fiyat: {Fiyat} TL/gün");
        }
    }

    // Binek Araba sınıfı
    class BinekAraba : Arac
    {
        public BinekAraba(string marka, string model, int yil, double fiyat)
            : base(marka, model, yil, fiyat) { }

        public override void BilgileriGoster()
        {
            Console.WriteLine($"Binek Araba - Marka: {Marka}, Model: {Model}, Yıl: {Yil}, Fiyat: {Fiyat} TL/gün");
        }
    }

    // Ticari Araba sınıfı
    class TicariAraba : Arac
    {
        public TicariAraba(string marka, string model, int yil, double fiyat)
            : base(marka, model, yil, fiyat) { }

        public override void BilgileriGoster()
        {
            Console.WriteLine($"Ticari Araba - Marka: {Marka}, Model: {Model}, Yıl: {Yil}, Fiyat: {Fiyat} TL/gün");
        }
    }

    // Jip Araba sınıfı
    class SUVAraba : Arac
    {
        public SUVAraba(string marka, string model, int yil, double fiyat)
            : base(marka, model, yil, fiyat) { }

        public override void BilgileriGoster()
        {
            Console.WriteLine($"SUV Araba - Marka: {Marka}, Model: {Model}, Yıl: {Yil}, Fiyat: {Fiyat} TL/gün");
        }
    }
}

