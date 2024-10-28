using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiftTekTop
{
    class Program
    {
        static void Main(string[] args)
        {




            Console.WriteLine("Sayı giriniz:");

            int CiftTop = 0;
            int TekTop = 0;

        

            while (true)
            {
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi < 0)
                    Console.WriteLine("Lütfen negatif sayı girmeyin");


                if (sayi == 0)
                           break;

                 else if (sayi % 2 == 0)
                    CiftTop += sayi;

                else
                {
                    TekTop += sayi;
                }

               


            }

            Console.WriteLine("Çift Top:" + CiftTop + " Tek toplam:" + TekTop);

            Console.ReadLine();



        }
    }
}
