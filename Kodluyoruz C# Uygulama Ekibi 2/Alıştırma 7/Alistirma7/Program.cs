using System;

namespace Alistirma7
{
    class Program//Author by Sinan Kapusız.
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir metin girin : ");
            string metin =Console.ReadLine();
            Console.Write("Girdiğiniz metin kaç kere gösterilecek : ");
            int gosterimSayisi=Int32.Parse(Console.ReadLine());
            for (int i = 0; i < gosterimSayisi; i++)
            {
                Console.WriteLine(metin);
            }
        }
    }
}
