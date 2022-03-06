using System;

namespace Alistima3
{
    class Program//Author By Sinan KAPUSIZ.
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir Sayı girin : ");
            int sayi =Int32.Parse(Console.ReadLine());
            Console.WriteLine(sayi%2 == 0 ? sayi/2 : sayi * 2);
        }
    }
}
