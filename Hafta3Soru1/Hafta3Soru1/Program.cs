using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3Soru1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Kaç eleman gireceksin:");

            int elemanSay =Convert.ToInt32( Console.ReadLine());

            int[] Sayilar = new int[elemanSay];

            Console.WriteLine("Elemanları giriniz:");

          
                for(int i = 0; i < elemanSay; i++)
                {
                    int sayi= Convert.ToInt32(Console.ReadLine());
                    Sayilar[i] = sayi;
                }

                //Sayıları küçükten büyüğe sıralamamız lazım


                for(int i =0;i< Sayilar.Length - 1; i++)
                {
                        for(int j = 0; j < Sayilar.Length - i - 1; j++)
                        {
                            if (Sayilar[j] > Sayilar[j + 1])
                            {
                                int temp = Sayilar[j];
                                Sayilar[j + 1] = Sayilar[j];
                                Sayilar[j] = temp;
                            }

                    
                  
                         
                        }

                }
                foreach(int sayi in Sayilar)
            {
                Console.WriteLine(sayi + " ");
            }

            

                





        }
    }
}
