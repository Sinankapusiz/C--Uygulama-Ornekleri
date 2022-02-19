using System;

namespace Alistirma6
{
    class Program
    {
        static void Main(string[] args)
        {
            float kilo = 0, boy = 0;
            float vucutKitleIndeks = 0f;
            Console.Write("Lütfen kilonuzu giriniz : ");
            kilo = float.Parse(Console.ReadLine());
            Console.Write("Lütfen boyunuzu giriniz : ");
            boy = float.Parse(Console.ReadLine());
            vucutKitleIndeks = kilo / ((boy * boy) / 10000);

            Console.WriteLine("================================================");
            Console.WriteLine("Vücut Kitle İndexiniz : {0}", vucutKitleIndeks);
            if (vucutKitleIndeks < 18)
            {
                Console.WriteLine("Zayıf");
            }
            else if (vucutKitleIndeks >= 18 && vucutKitleIndeks < 25)
            {
                Console.WriteLine("Normal");
            }
            else if (vucutKitleIndeks >= 25 && vucutKitleIndeks < 30)
            {
                Console.WriteLine("Kilolu");
            }
            else if (vucutKitleIndeks >= 30 && vucutKitleIndeks < 35)
            {
                Console.WriteLine("Obez");
            }
            else
            {
                Console.WriteLine("Ciddi Obez");
            }
        }
    }
}
