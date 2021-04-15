using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri : " + musteri.Adi + " " + musteri.Soyad + " eklendi.");


        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri : " + musteri.Adi + " " + musteri.Soyad + " silindi.");


        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri : " + musteri.Adi + " " + musteri.Soyad + " listelendi.");
        }
    }
}
