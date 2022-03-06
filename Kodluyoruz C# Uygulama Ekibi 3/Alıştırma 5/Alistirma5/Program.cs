using System;

namespace Alistirma5
{
    class Program//Author By Sinan KAPUSIZ.
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir sayı girin : ");
            int sayi = Int32.Parse(Console.ReadLine());
            Console.WriteLine(BolenSaysiniBul(sayi));
        }
        public static int BolenSaysiniBul(int sayi)
        {
            int bolunenSayiSayisi = 0;
            for (int i = 1; i <= 200; i++)
            {
                if (i % sayi == 0)
                    bolunenSayiSayisi++;
            }
            return bolunenSayiSayisi;
        }
    }
}
