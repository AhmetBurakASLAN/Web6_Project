using System;

namespace Proje_11_Metot_Örnekleri_1
{
    class Program
    {
        static void Main(string[] args)
        {

           //int tahmin()
           // {
           //     Random rndsayı = new Random();
           //     int rastgele = rndsayı.Next(1, 100);

           // }
            int rastgeleSayı()
            {
                Random rndsayı = new Random();
                int rastgele = rndsayı.Next(1, 100);
                return rastgele;
            }
           
            int karsılastırma(int number1,int number_i,int numberRastgele)
            {
                int bitme = 0;
                if ( number1 == numberRastgele && number_i<6)
                {
                    int puan = 50 - (number_i - 1) * 10;
                    Console.WriteLine($"tebrikler, puanınız :{puan}");

                    bitme = 1;
                    return bitme;

                }
                else
                {
                    Console.WriteLine($"kaybettiniz,kalan hak{5 - number_i},kalan puan{(5 - number_i) * 10}");
                    bitme = 2;
                    return bitme;
                }
            }
            
            int tahminYapma()
            {
                Console.WriteLine("Tahminizi giriniz: ");
                int tahmin = int.Parse(Console.ReadLine());
                return tahmin;
            }
            string tekrarOynama()
            {
                Console.WriteLine(" tekrar oynamak istiyor musunuz? (E yazınız)");
                string istek = Console.ReadLine();
                return istek;
            }

            int rastgeleSayı1 = rastgeleSayı();
            Console.WriteLine(rastgeleSayı1);
            int i = 1;
            while (i<6 )
            {
                int tahmin = tahminYapma();
                int kazanma = karsılastırma(tahmin, i, rastgeleSayı1);
                if (kazanma==1)
                {
                    break;
                }                                                                           
                if (kazanma!=1 && i == 5)
                {
                    if (tekrarOynama() == "E")
                    {
                        Console.Clear();
                        i = 0;
                    }
                    
                }
                i++;
            }
            Console.ReadLine();
        
        }     



    }
}
