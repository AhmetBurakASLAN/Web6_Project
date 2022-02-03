using System;

namespace Proje_07_While
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sayi = 1;
            //while (sayi<=5)
            //{
            //    Console.WriteLine($"{sayi}Hello World!");
            //    sayi++;

            //}
            //Console.WriteLine(sayi);

            /*
            int sayi = 1;
            int toplam = 0;
            while (sayi<=5)
            {
                
                toplam = toplam + sayi;
                Console.WriteLine(sayi);
                
                sayi++;

            }
            Console.WriteLine($"toplam :{toplam}");
            */

            /*
            string girilecek = " ";
            

            while (girilecek != "exit")
            {
                
                Console.WriteLine("hello world");
                girilecek = Console.ReadLine();

            }
            Console.ReadLine();
            */

            /*
             string girilecek;
            do
            {
                Console.WriteLine("hello world");
                girilecek = Console.ReadLine();
            } while (girilecek != "exit");
            */

            /*yanlış progrma
             * string kullaniciAdi = "admin";
             string sifre = "123";
             int sayi = 1;
             do
             {

                 if (sayi == 0)
                 {
                     Console.WriteLine("giriş başarısız");

                 }
                 Console.Clear();
                 Console.WriteLine("kullanıcı adınızı giriniz");
                 kullaniciAdi = Console.ReadLine();
                 Console.WriteLine("şifrenizi giriniz");
                 sifre = Console.ReadLine();

                 sayi--;

             } while (kullaniciAdi != "admin" || sifre!="123");
             Console.Clear();
             Console.WriteLine("giriş başarılı");
             Console.ReadLine();
            doğru program aşağıda
            */

            //string userName = "admin";
            //string pass = "123";
            //string gUserName;
            //string gPass;
            //bool durum = false;
            //do
            //{
            //    if (durum)
            //    {
            //        Console.WriteLine("Hatalı Kullanıcı Girişi");
            //        Console.ReadLine();
            //        Console.Clear();
            //    }

            //    Console.WriteLine("Kullanıcı Adı: ");
            //    gUserName = Console.ReadLine();
            //    Console.Write("şifre:");
            //    gPass = Console.ReadLine();
            //    durum = true;


            //} while (gUserName!=userName||gPass!=pass);;
            //Console.WriteLine("başarılı");
            //Console.ReadLine();

            //Klavyeden ard arda sayı girişi yapılmasını sağlayan ve girilen sayıların toplamı 1000'i geçene kadar 
            //yada 10 adet sayı girilen sayı adetini ekrana yazdıran programı hazırlayınız.

            /* eksik program 
             int sayac = 0;
            int toplam = 0;
            int sayi;
            while (sayac<=10 )
            {
           
                sayi = Convert.ToInt32(Console.ReadLine());
                toplam = toplam + sayi;
                Console.WriteLine($"{toplam}");
                sayac++;
            }
            Console.WriteLine("deneme");
            Console.ReadLine();
             
           */
            int sayi = 0;
            int toplam = 0;
            int sayac = 0;
            do
            {
                sayac--;
                Console.Write("sayı giriniz" );
                sayi= int.Parse(Console.ReadLine());

                adet++;
                cw
            } while (true);

        }
    }

}
