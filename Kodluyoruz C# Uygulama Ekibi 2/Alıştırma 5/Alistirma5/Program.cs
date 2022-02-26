using System;

namespace Alistirma5
{
    class Program//Author By Sinan Kapusız. 
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i+". Sayıyı giriniz : ");
                toplam += Int32.Parse(Console.ReadLine()); 
            }
            Console.WriteLine("Girilen sayıların toplamı : "+toplam);
        }
    }
}
