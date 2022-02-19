using System;

namespace Alistirma3
{
    class Program
    {
        static void Main(string[] args)
        {
            int kisaKenar = 0, uzunKenar = 0;
            Console.Write("Kısa Kenar : ");
            kisaKenar = Int32.Parse(Console.ReadLine());
            Console.Write("Uzun Kenar : ");
            uzunKenar = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Alan : {0}",kisaKenar*uzunKenar);
            Console.WriteLine("Çevre : {0}",2 * (kisaKenar + uzunKenar));
        }
    }
}
