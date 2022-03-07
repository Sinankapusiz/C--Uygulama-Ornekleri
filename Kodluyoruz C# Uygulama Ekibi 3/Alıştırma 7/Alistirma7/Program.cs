using System;

namespace Alistirma7//Author By Sinan KAPUSIZ.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir sıcaklık derecesi girin : ");
            int girilenDerece = Int32.Parse(Console.ReadLine());
            Console.WriteLine(girilenDerece + " girilen derece " + (girilenDerece * 1.8 + 32) + " Fahrenhayt.");
        }
    }
}
