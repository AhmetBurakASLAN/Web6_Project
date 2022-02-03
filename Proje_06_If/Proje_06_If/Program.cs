using System;

namespace Proje_06_If
{
    class Program
    {
        static void Main(string[] args)
        {

            //int sayi = 1;
            //if (sayi >5)
            //{
            // TRUE İSE
            //   Console.WriteLine("BÜYÜK");
            //}
            //else
            //{
            //    //FALSE İSE
            //    Console.WriteLine("KÜÇÜK");
            Console.Write("bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi>50)
            {
                Console.WriteLine("sayı 50'den büyüktür");
            }
            else if(sayi<50)
            {
                Console.WriteLine("sayı 50'den küçüktür");
            }
            else
            {
                Console.WriteLine("sayı 50'ye eşittir");

            }
            Console.ReadLine();

            }
        


        }
    }