using System;

namespace Alistirma7
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin ;
            int harfSayisi = 0;
            Console.Write("Lütfen metin giriniz : ");
            metin = Console.ReadLine();
            for (int i = 0; i < metin.Length; i++)
            {
                if(metin[i] != ' ')
                {
                    harfSayisi++;
                }
            }
            Console.WriteLine("Girdiğiniz metinde {0} adet harf var.",harfSayisi);
        }
    }
}
