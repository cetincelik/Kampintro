using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Ali";
            musteri1.Soyad = "Çalışkan";
            musteri1.Id = 1;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Veli";
            musteri2.Soyad = "Üşengeç";
            musteri2.Id = 2;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager MusteriManager = new MusteriManager();
            MusteriManager.Ekle(musteri1);
            MusteriManager.Ekle(musteri2);
            MusteriManager.Listele(musteri1);
            MusteriManager.Sil(musteri2);


        }
    }
}
