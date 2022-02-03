using System;

namespace Proje_04_Reference_Types
{
    class Program
    {
        class Kisi
        {
            public string Ad { get; set; }
            public int Yas { get; set; }

        }
        static void Main(string[] args)
        {
            Kisi person1 = new Kisi();
            person1.Ad = "Engin";
            person1.Yas = 47;
            Console.WriteLine($"{person1.Ad}, sen {person1.Yas} yaşındasın");

            Kisi person2 = new Kisi();
            person2.Ad = "Umay";
            person2.Yas = 15;

            Console.WriteLine($"{person2.Ad}, sen {person2.Yas} yaşındasın");
            person2 = person1;

            Console.WriteLine($"{person1.Ad}, sen {person1.Yas} yaşındasın");
            Console.WriteLine($"{person2.Ad}, sen {person2.Yas} yaşındasın");


            Console.ReadLine();

        }
    }
}
