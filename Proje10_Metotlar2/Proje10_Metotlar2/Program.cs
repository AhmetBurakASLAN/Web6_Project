using System;

namespace Proje10_Metotlar2
{
    class Program
    {
        static int Topla(int number1, int number2, int number3)
        {

            return number1 + number2 + number3;
        }
        static int Topla(int number1, int number2)
        {
            int sonuc = number1 + number2;
            return number1 + number2;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(Topla(56,112));
            Console.WriteLine(Topla(452,69,69));

            Console.WriteLine(Topla(50,90));
            Console.WriteLine(Topla(Topla(Topla(50,250),900),1000));

            int a = Topla(58555, 56546);
            Console.ReadLine();





        }
    }
}
