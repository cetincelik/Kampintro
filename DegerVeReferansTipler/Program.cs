using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Değer tiplerde değeri atarsın. Referans tiplerde adressi atarsın


            // ----------değer tip----------
            // değer tipler stack'te tanımlanır. Sadece değer aktarılır ve bağ kopor
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ? 30


            //---------referans tip--------------
            //referans tiplerde heap'de alan oluşturur ve değerler oraya yazılır.

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 10, 20, 30 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] ? 999
        }
    }
}
