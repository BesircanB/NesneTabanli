using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciAdımSayisi
{
    class Program
    {
        static void Main(string[] args)
        {

           





            Console.WriteLine("Bİr sayı giriniz:");

            int adim = Convert.ToInt32(Console.ReadLine());


                int sayi1 = 1;
                int sayi2 = 2;
                int top = 3;

            Console.Write(1 + " " + 2+" "+3+" ");





            for(int i = 0; i < adim-3; i++)
            {
                sayi1 = sayi2;
                sayi2 = top;
                top = sayi1 + sayi2;
                Console.Write(top+" ");
                if (adim == 11&& i==8)
                    break;

            }
                

               



            


           


            Console.ReadLine();





        }
    }
}
