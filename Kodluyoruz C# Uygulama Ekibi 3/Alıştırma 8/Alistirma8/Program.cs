using System;

namespace Alistirma8
{
    class Program//Author By Sinan Kapusız.
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir metin giriniz : ");
            string[] metin = Console.ReadLine().Split(' ');
            Console.WriteLine("Sonuç : " + metin[0]);
        }
    }
}
