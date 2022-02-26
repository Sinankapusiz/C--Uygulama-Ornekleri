using System;

namespace Alistirma3
{
    class Program
    {
        static void Main(string[] args)
        {
            int girilecekKelimeSayisi = 0;
            Console.Write("Girilecek kelime sayısı : ");
            girilecekKelimeSayisi = Int32.Parse(Console.ReadLine());

            string[] kelimeler = new string[girilecekKelimeSayisi];

            for (int i = 0; i < girilecekKelimeSayisi; i++)
            {
                Console.Write("lütfen kelime giriniz : ");
                kelimeler[i] = Console.ReadLine();
            }

            Console.WriteLine("----------------------------");

            Array.Sort(kelimeler);
            foreach(var k in kelimeler)
            {
                Console.WriteLine(k);
            }
        
        }
    }
}
