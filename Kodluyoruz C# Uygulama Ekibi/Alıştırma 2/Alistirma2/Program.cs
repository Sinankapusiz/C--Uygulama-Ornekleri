using System;

namespace Alistirma2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 0,sayi2 = 0;
            Console.Write("1.Sayı : ");
            sayi1 =Int32.Parse(Console.ReadLine());
            Console.Write("2.Sayı : ");
            sayi2 =Int32.Parse(Console.ReadLine());
            Console.WriteLine("{0} ve {1} Sayısının Toplamı : {2}",sayi1,sayi2,sayi1+sayi2);
        }
    }
}
