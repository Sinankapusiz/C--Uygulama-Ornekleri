using System;

namespace Alistirma1
{
    class Program//Author Sinan KAPUSIZ
    {
        static void Main(string[] args)
        {
            string metin;
            Console.Write("Lütfen bir metin girin : ");
            metin = Console.ReadLine();
            string[] kelimeler = metin.Split(' ');
            Console.WriteLine("Girdiğiniz metindeki toplam kelime sayısı : "+kelimeler.Length);
        }
    }
}
