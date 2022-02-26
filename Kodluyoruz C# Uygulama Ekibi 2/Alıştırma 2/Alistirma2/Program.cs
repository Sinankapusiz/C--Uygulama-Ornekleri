using System;

namespace Alistirma2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.Write("Lütfen bir sayı girin : ");
            n = Int32.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.WriteLine(i+" sayısı 3 ve 7 bölüne biliyor.");
                }
            }
        }
    }
}
