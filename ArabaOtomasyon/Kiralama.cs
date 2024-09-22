using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaOtomasyon
{


    // Kiralama sınıfı
    class Kiralama
    {
        public Musteri Musteri { get; set; }
        public Arac KiralananArac { get; set; }
        public int KacGun { get; set; }

        public Kiralama(Musteri musteri, Arac kiralananArac, int kacGun)
        {
            Musteri = musteri;
            KiralananArac = kiralananArac;
            KacGun = kacGun;
        }

        public void KiralamaBilgileriGoster()
        {
            Musteri.MusteriBilgileriGoster();
            KiralananArac.BilgileriGoster();
            Console.WriteLine($"Kiralama Süresi: {KacGun} gün, Toplam Tutar: {KacGun * KiralananArac.Fiyat} TL\n");
        }
    }

}
