using System;

namespace Alistirma4
{
    class Program//Author By Sinan KAPUSIZ.
    {
        static void Main(string[] args)
        {
            Console.Write("Faktöriyeli hesaplanacak sayıyı girin : ");
            Console.WriteLine("Sonuç : " + FaktoriyeliniHesapla(Int32.Parse(Console.ReadLine())));
            
        }
        public static int FaktoriyeliniHesapla(int sayi)
        {
            int fak = 1;
            for (int i = 1; i <= sayi; i++)
            {
                fak *= i;
            }
            return fak;
        }
    }
}
