using System;

namespace Alistirma1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad, soyad;
            Console.Write("Adınız : ");
            ad = Console.ReadLine();
            Console.Write("Soyadınız : ");
            soyad = Console.ReadLine();
            Console.Write("Merhaba {0} {1}",ad,soyad);
        }
    }
}
