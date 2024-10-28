using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmStrong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz:");

            int sayi = Convert.ToInt32(Console.ReadLine());


            int basSayisi=0;
            while (sayi>0)
            {

                 sayi /= 10;
                basSayisi++;
            }
            int AsilSonuc = 0;


            while (sayi > 0)
            {
                int Sonbas = sayi % 10;
                int sonuc =1;

                for(int i = 0; i < basSayisi; i++)
                {

                    sonuc *= Sonbas;
                }
                AsilSonuc += sonuc;

                sayi /= 10;

            }

            Console.WriteLine(AsilSonuc);
            Console.ReadLine();

        }
    }
}
