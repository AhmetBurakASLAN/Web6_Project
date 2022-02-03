using System;

namespace Proje_05_Convert_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Adınızı giriniz : ");
            //string ad = Console.ReadLine();
            //Console.WriteLine($"Merhaba {ad}, hoşgeldin.");

            //Console.Write("Bir sayı giriniz: ");
            //int sayi = Convert.ToInt32( Console.ReadLine());
            //Console.WriteLine((sayi*sayi));

            //Console.Write("Lütfen birinci sayıyı giriniz: ");
            //int sayı1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Lütfen ikinci sayıyı giriniz: ");
            //int sayı2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Toplam: {sayı1+sayı2}");

            //byte b = 15;
            //short s = b;
            //short s1 = 258;
            //byte b1 = (byte)s1;
            //Console.WriteLine($"s1-short : {s1} ===> b1-byte : {b1}");

            Console.Write("1. Kenarın uzunluğunu giriniz: ");
            int kenar1 = int.Parse(Console.ReadLine());
            Console.Write("2. Kenarın uzunluğunu giriniz: ");
            int kenar2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Girdiğini değerlere göre alan :{kenar1*kenar2}");




            Console.ReadLine();

        }
    }
}
