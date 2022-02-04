using System;

namespace Proje10_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            void Topla ()
            {
                int a = 8;
                int b = 10;
                Console.WriteLine(a+b);
            }
          

            void Yaz()
            {

                Console.WriteLine("Merhaba wissen");
            }

            
            void Yaz2(string Ad)
            {
                Console.WriteLine($"Merhaba {Ad}");
            }
            
            void Topla2(int sayi1 ,int sayi2)
            {
                Console.WriteLine(sayi1+sayi2);
            }
            void IslemYap(string secim)
            {

                int sonuc=0;
                if (secim=="+"||secim=="*"||secim=="-"||secim=="/")
                {
                    Console.WriteLine("Birinci sayıyı giriniz: ");
                    int sayi1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("İkinci sayıyı giriniz: ");
                    int sayi2 = int.Parse(Console.ReadLine());
                    



                    if (secim == "+")
                    {
                        sonuc = sayi1 + sayi2;
                    }
                    else if (secim == "-")
                    {
                        sonuc = sayi1 - sayi2;

                    }
                    else if (secim == "*")
                    {
                        sonuc = sayi1 * sayi2;

                    }
                    else 
                {
                        sonuc = sayi1 / sayi2;

                    }
                    Console.WriteLine($"sonuc: {sonuc}");
                }
                else
                {
                    Console.WriteLine("Lütfen doğru bir işlem giriniz");
                    Console.ReadLine();

                }
                
                            

            }
            //Yaz();
            //Topla();
            //Topla2(60, 70);
            //Topla2(120, 580); 
            IslemYap("k");

            Console.ReadLine();





                
        }
    }
}
