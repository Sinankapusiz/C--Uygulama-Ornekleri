using System;

namespace Alistirma6
{
    class Program//Author by Sinan Kapusız.
    {
        static void Main(string[] args)
        {
            int tek = 0, cift = 0;
            for (int i = 0; i < 10; i++)
            {
                Random rastgeleSayi = new Random();
                int sayi = rastgeleSayi.Next();
                Console.WriteLine("Rastgele sayı tutulan sayı : " + sayi);
                if (sayi % 2 == 0)
                    cift++;
                else
                    tek++;
            }
            Console.WriteLine("Toplam çift sayı adeti : " + cift + " Toplam tek sayı adeti : " + tek);
        }
    }
}
