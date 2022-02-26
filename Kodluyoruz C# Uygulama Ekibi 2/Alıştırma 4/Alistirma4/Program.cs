using System;

namespace Alistirma4
{
    class Program
    {
        static void Main(string[] args)//Author By Sinan Kapusız.
        {
            string metin;
            Console.Write("Lütfen bir metin girin : ");
            metin = Console.ReadLine();

            string sesliHarfler =  "aeıioöuüAEIİOÖUÜ" ;

            Console.Write("'"+metin+"' metnindeki sesli harfler : ");
            for (int i = 0; i < metin.Length; i++)
            {
                for (int j = 0; j < sesliHarfler.Length; j++)
                {
                    if (metin[i] == sesliHarfler[j])
                    Console.Write(sesliHarfler[j]+", ");
                }
            }
        }
    }
}
