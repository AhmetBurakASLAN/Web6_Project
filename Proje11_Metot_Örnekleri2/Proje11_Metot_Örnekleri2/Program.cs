using System;

namespace Proje11_Metot_Örnekleri2
{
    class Program
    {

        static int buyukKarsılasması(int number1, int number2)
        {

            if (number1 >= number2)
            {


                return number1;
            }
            else
            {
                return number2;
            }
        }
        static int BuyukBul(int[] sayilar)
            {
            int enb = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i]>enb)
                {
                    enb = sayilar[i];
                }
            }

            return enb;
        }
            


            static void Main(string[] args)
        {
            //int number1 = 555;
            //int number2 = 555;
            //int buyuk1 = buyukKarsılasması(number1, number2);
            //Console.WriteLine(buyuk);
            //Console.ReadLine();

            int[] sayilar = { 15, 76, 55, 966, 45, 134, 87 };
            int buyuk = BuyukBul(sayilar);
            Console.WriteLine(buyuk);
            Console.ReadLine();



        }
        
    }
}
