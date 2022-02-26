using System;

namespace Alistirma1
{
    class Program //Author By Sinan Kapusız.
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 1000000; i++)
            {
                
                bool asalSayi = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        asalSayi = false;
                        break;
                    }
                }
                if(asalSayi == true)
                {
                    Console.WriteLine(i+" Asal Sayı.");
                }   
            }
        }
    }
}
