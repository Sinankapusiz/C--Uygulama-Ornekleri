using System;

namespace Alistirma6
{
    class Program//Author By Sinan KAPUSIZ.
    {
        //
        static void Main(string[] args)
        {
            bool isimVar = false;
            string[] isimler = {"osman","burak","mehmet","sinan","zafer","hakan","caner","volkan","süleyman","mehmet"};
            Console.Write("Lütfen isminizi giriniz : ");
            string aranacakIsim = Console.ReadLine();
            aranacakIsim = aranacakIsim.ToLower();
            foreach (var isim in isimler)
            {
                if (isim == aranacakIsim)
                {
                    Console.WriteLine("Bu "+aranacakIsim+", isimler dizisinde var.");
                    isimVar = true;
                }
            }  
            if (!isimVar)
            {
                Console.WriteLine("Bu "+aranacakIsim+", isimler dizisinde yok.");
            }         
        }
    }
}
