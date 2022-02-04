using System;

namespace Proje_09_Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] firstArray = { 40, 50, 80 };
            
            for (int i = 0;  i<3; i++)
            {
                Console.WriteLine(firstArray[i]);
            }
            */
            /*
            Random rnd = new Random();
            
            for (int i = 0; i < 10; i++)
            {
                
                int rastgele = rnd.Next(1, 100);
                Console.WriteLine(rastgele);
            }
            Console.ReadLine();
            */

            //Random rgl = new Random();
            //int[] sayilar = new int [5];
            //for (int i = 0; i < 5; i++)
            //{
            //    sayilar[i] = rgl.Next(1, 100);
            //}

            /*
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(sayilar[i]*2);
            }
            */

            ////foreach (var sayi in sayilar)
            ////{
            ////    Console.WriteLine(sayi);
            ////}
            ////Console.ReadLine();
            /*programımız 1  ile 100 arasında rastgele bir sayı üretsin.Kullanıcıdan bu sayıyı 
             * tahmin etmenisini isteyelim
             * bilirse tebrik edelim bilemezse kaybedelim.
             */
            /*
            Random rnd = new Random();
            int sayi = rnd.Next(1, 100);
            Console.WriteLine("Bir tahmin giriniz: ");
            int tahmin = int.Parse(Console.ReadLine());
            if (sayi==tahmin)
            {
                Console.WriteLine("tebrikler");

            }
            else
            {
                Console.WriteLine("kaybettiniz");

            }
            Console.ReadLine();
            */
            /* 
            Random rnd = new Random();
            int sayi = rnd.Next(1, 100);
            Console.WriteLine(sayi);

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Bir tahmin giriniz: ");
                int tahmin = int.Parse(Console.ReadLine());
                if (i<6 && sayi == tahmin)
                {
                    Console.WriteLine("tebrikler");
                    break;
                }
                else
                {
                    Console.WriteLine("kaybettiniz");
                    
                }
            

            }
            Console.ReadLine();  
            */

            /* 1. yol********* 2.yol ile baştaki 3 satır aynı
            Random rnd = new Random();
            int sayi = rnd.Next(1, 100);
            Console.WriteLine(sayi);
            
            int i = 1;
            do
            {
                Console.WriteLine("Bir tahmin giriniz: ");
                int tahmin = int.Parse(Console.ReadLine());
                if (sayi == tahmin)
                {
                    Console.WriteLine("tebrikler");
                    break;
                }
                else
                {
                    Console.WriteLine("kaybettiniz");

                }

                i++;
            } while (i<6);
            if (i == 6)
            {
                Console.WriteLine("hakkınız bitti");
            }
            Console.ReadLine();
            */
            /*  2.yol*****************
               while (i<6)
               {
                   Console.WriteLine("Bir tahmin giriniz: ");
                   int tahmin = int.Parse(Console.ReadLine());
                   if ( sayi == tahmin)
                   {
                       Console.WriteLine("tebrikler");
                       break;
                   }
                   else
                   {
                       Console.WriteLine("kaybettiniz");

                   }

                   i++;
               }
            
            if (i==5)
            {
                Console.WriteLine("hakkınız bitti");
            }
            Console.ReadLine(); 
            */
            Random rnd = new Random();
            int sayi = rnd.Next(1,100);
            Console.WriteLine(sayi);
            int i ;
            for ( i = 1; i < 6; i++)
            {
                Console.Write("Bir tahmin giriniz: ");
                int tahmin = int.Parse(Console.ReadLine());
                if (i < 6 && sayi == tahmin)
                {
                    
      
                    int puan = 50-(i-1)*10 ;
                    Console.WriteLine($"tebrikler, puanınız :{puan}");
                    break;
                }
                else
                {
                    Console.WriteLine("kaybettiniz");

                }

                Console.WriteLine($"kalan hak {5-i}, kalan puan {50-(i)*10}");
            }
            if (i == 6)
            {
                Console.WriteLine("hakkınız bitti");
            }
            Console.ReadLine();

        }
    }
}
