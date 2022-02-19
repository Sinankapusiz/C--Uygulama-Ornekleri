using System;

namespace Alistirma5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            Console.Write("Lütfen bir sayi giriniz : ");
            sayi = Int32.Parse(Console.ReadLine());
            Console.Write(sayi > 0 & sayi < 100 ? (sayi +" 0-100 arasında."):(sayi +" 0-100 arasında değil."));
        }
    }
}
