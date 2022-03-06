using System;

namespace Alistirma2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("lütfen bir metin girin : ");
            string metin = Console.ReadLine();
            Console.Write("Lütfen aranacak Karakteri girin : ");
            char aranacakKarakter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Karakterin bulunma sayısı : " + Substring(metin, aranacakKarakter));
        }
        public static int Substring(string metin, char aranacakKarakter)
        {
            int karakterinBulunmaSayisi = 0;
            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i] == aranacakKarakter)
                    karakterinBulunmaSayisi++;
            }
            return karakterinBulunmaSayisi;
        }
    }
}
