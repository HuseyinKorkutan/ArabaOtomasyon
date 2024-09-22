using ArabaOtomasyon;
using System;
using System.Collections.Generic;


namespace AracKiralamaOtomasyonu

{ 

    class Program
    {
        static void Main(string[] args)
        {
            // Araç nesneleri oluşturuyorum

            ArabaOtomasyon.BinekAraba binek1 = new ArabaOtomasyon.BinekAraba("Toyota", "Corolla", 2020, 1500);
            ArabaOtomasyon.BinekAraba binek2 = new ArabaOtomasyon.BinekAraba("Honda", "Civic", 2021, 1600);
            ArabaOtomasyon.TicariAraba ticari1 = new ArabaOtomasyon.TicariAraba("Ford", "Transit", 2019, 2000);
            ArabaOtomasyon.TicariAraba ticari2 = new ArabaOtomasyon.TicariAraba("Mercedes", "Sprinter", 2020, 2200);
            ArabaOtomasyon.SUVAraba suv1 = new ArabaOtomasyon.SUVAraba("Land Rover", "Discovery", 2021, 3000);
            ArabaOtomasyon.SUVAraba suv2 = new ArabaOtomasyon.SUVAraba("Jeep", "Wrangler", 2022, 3500);

            // Araçları liste olarak tutalım
            List<Arac> araclar = new List<Arac> { binek1, binek2, ticari1, ticari2, suv1, suv2 };

            // Müşteri bilgilerini alalım
            Console.Write("Adınızı girin: ");
            string ad = Console.ReadLine();
            Console.Write("Soyadınızı girin: ");
            string soyad = Console.ReadLine();
            Console.Write("Telefon numaranızı girin: ");
            string telefon = Console.ReadLine();
            Musteri musteri = new Musteri(ad, soyad, telefon);

            // Araçları gösteriyorum
            Console.WriteLine("\nKiralayabileceğiniz araçlar:");
            for (int i = 0; i < araclar.Count; i++)
            {
                Console.Write($"{i + 1}. ");
                araclar[i].BilgileriGoster();
            }
            sss

            // Kullanıcıdan  kiralama süresi istiyorum
            Console.Write("\nKiralamak istediğiniz aracın numarasını girin: ");
            int aracSecim = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Write("Kaç gün kiralamak istiyorsunuz? ");
            int gunSayisi = Convert.ToInt32(Console.ReadLine());

            // Seçilen araç ile kiralama işlemi
            Arac secilenArac = araclar[aracSecim];
            Kiralama kiralama = new Kiralama(musteri, secilenArac, gunSayisi);

            // Kiralama bilgilerini göster
            kiralama.KiralamaBilgileriGoster();
        }
    }
}
