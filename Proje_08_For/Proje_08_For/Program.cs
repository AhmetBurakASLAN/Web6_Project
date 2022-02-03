using System;

namespace Proje_08_For
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int toplam = 0;
            int i = 0;
            int a;
            for ( i = 1; i <11; i++)
            {
                if (i%2==0)
                {
                    toplam = toplam + i  ;
                    Console.WriteLine($"{i}");
                        }

                         }
            Console.WriteLine($"{toplam}");
            Console.ReadLine();
            */
            /* 1 ile 100 arasındaki asal sayıları bulun ve ekrana yazdırın*/
            /*int i = 0;
            for (i = 0; i < 1000; i++)
            {
                if (i%2!=0 && i%3!=0 && i%5!=0 && i%7!=0||i==2 ||i==3 ||i==5 ||i==7)
                {
                    Console.WriteLine($"asal sayılar  {i}");
                }
            }
            Console.ReadLine();
            */

            /* 1 ile 100 arasındaki asal sayıları bulun ve ekrana yazdırın*/
            /* bool asal = true;

             for (int i = 2; i < 100; i++)// asal mı değil mi diye kontrol edilecek sayılar
             {

                 for ( int j =2 ; j < i; j++) //bölünme kuralını kontrol ediyoruz
                 {
                     if (i % j == 0 )
                     {
                         asal=false;
                         break;
                     }
                 }
                 if (asal)
                 {
                     Console.WriteLine(i);
                 }
                 asal = true;
             }
             Console.ReadLine();
            */

            /*bir ile 100 arasında 5 ile 7nin katı olmayan sayıları yazdıralım*/
            /* for (int i = 2; i < 100; i++)
             {


                     if (i % 5 == 0 && i%7==0)
                     {
                         Console.WriteLine(i);

                     }


             }
             Console.ReadLine();
            */
            /*
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("*"+" ");

                }
                Console.WriteLine();
            }
            Console.ReadLine(); */

            /*çarpım tablosu programı */
            /*
            for (int i = 1; i < 10; i++)
            {
                
                for (int j = 1; j < 10; j++)
                {
                    int carpım = i * j;

                    Console.Write($"{carpım}\t");
                    

                }
                
                Console.WriteLine();

            }
            
            Console.ReadLine();
            */
            /*klavyeden girilecek 3 adet sayıdan en büyük olanı bulup ekrana yazdırın*/
       
              /*                      
            int enBuyuk=0;
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Sayı giriniz:");
                int girilenSayı = int.Parse(Console.ReadLine());
                if (enBuyuk < girilenSayı)
                {
                    enBuyuk = girilenSayı;
                }
              
                
                                           
            }
            Console.WriteLine($"en büyük {enBuyuk}");

            Console.ReadLine();
            */

            int enBuyuk = 0;
            for (int i = 1; i <= 3; i++)
            {

                Console.WriteLine($"Sayı giriniz:");
                int girilenSayı = int.Parse(Console.ReadLine());
                if (enBuyuk < girilenSayı)
                {
                    enBuyuk = girilenSayı;
                }

            }
          Console.WriteLine($" {enBuyuk} ");
            Console.ReadLine();





        }
    }
}
