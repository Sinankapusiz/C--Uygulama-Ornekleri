using System;

namespace Alistirma4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            Console.Write("Lütfen bir sayı giriniz : ");
            sayi = Int32.Parse(Console.ReadLine());
            Console.WriteLine(sayi % 2 == 0 ? (sayi + " çift") : (sayi + " tek"));
        }
    }
}
