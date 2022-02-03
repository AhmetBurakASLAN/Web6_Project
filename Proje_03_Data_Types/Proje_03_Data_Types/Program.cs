using System;

namespace Proje_03_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------VERİ TİPLERİ---------");
            Console.WriteLine("A)Tamsayılar(Integral)");
            Console.WriteLine("a)İşaretsizler(Unsigned) Tamsayılar");
            Console.WriteLine("1) byte :");
            Console.WriteLine($"Minumum Değer {byte.MinValue}");
            Console.WriteLine($"Maximum Değer {byte.MaxValue}");
            Console.WriteLine($"Bellekteki Boyutu {sizeof(byte)} byte");

            Console.ReadLine();
            Console.WriteLine("2) ushort :");
            Console.WriteLine($"Minumum Değer {ushort.MinValue}");
            Console.WriteLine($"Maximum Değer {ushort.MaxValue:0,00}");
            Console.WriteLine($"Bellekteki Boyutu {sizeof(ushort)} byte");

            Console.ReadLine();
            Console.WriteLine("3) uint :");
            Console.WriteLine($"Minumum Değer {uint.MinValue}");
            Console.WriteLine($"Maximum Değer {uint.MaxValue:0,00}");
            Console.WriteLine($"Bellekteki Boyutu {sizeof(uint)} byte");

            Console.ReadLine();
            Console.WriteLine("4) ulong :");
            Console.WriteLine($"Minumum Değer {ulong.MinValue}");
            Console.WriteLine($"Maximum Değer {ulong.MaxValue:0,00}");
            Console.WriteLine($"Bellekteki Boyutu {sizeof(ulong)} byte");

            Console.ReadLine();

            Console.WriteLine("a)İşaretli(signed) Tamsayılar");
            Console.WriteLine("1) sbyte :");
            Console.WriteLine($"Minumum Değer {sbyte.MinValue}");
            Console.WriteLine($"Maximum Değer {sbyte.MaxValue}");
            Console.WriteLine($"Bellekteki Boyutu {sizeof(sbyte)} byte");
            Console.ReadLine();

            Console.WriteLine("2) short :");
            Console.WriteLine($"Minumum Değer {short.MinValue:0,00}");
            Console.WriteLine($"Maximum Değer {short.MaxValue:0,00}");
            Console.WriteLine($"Bellekteki Boyutu {sizeof(short)} byte");
            Console.ReadLine();

            Console.WriteLine("3) int :");
            Console.WriteLine($"Minumum Değer {int.MinValue:0,00}");
            Console.WriteLine($"Maximum Değer {int.MaxValue:0,00}");
            Console.WriteLine($"Bellekteki Boyutu {sizeof(int)} byte");
            Console.ReadLine();


            Console.WriteLine("3) long :");
            Console.WriteLine($"Minumum Değer {long.MinValue:0,00}");
            Console.WriteLine($"Maximum Değer {long.MaxValue:0,00}");
            Console.WriteLine($"Bellekteki Boyutu {sizeof(long)} byte");
            Console.ReadLine();

            Console.WriteLine("B)Ondalıklı(Decimal)");
            Console.WriteLine("1) float :");
            Console.WriteLine($"Minumum Değer {float.MinValue:0,00}");
            Console.WriteLine($"Maximum Değer{float.MaxValue:0,00}");
            Console.WriteLine($"Bellekteki Boyutu {sizeof(float)} byte");

            Console.ReadLine();

            Console.WriteLine("2) double");
            Console.WriteLine($"Minumum Değer {double.MinValue:0,00}");
            Console.WriteLine($"Maximum Değer{double.MaxValue:0,00}");
            Console.WriteLine($"Bellekteki Boyutu {sizeof(double)} byte");

            Console.ReadLine();

            Console.WriteLine("1) decimal");
            Console.WriteLine($"Minumum Değer {decimal.MinValue}");
            Console.WriteLine($"Maximum Değer{decimal.MaxValue}");
            Console.WriteLine($"Bellekteki Boyutu {sizeof(decimal)} byte");

            Console.ReadLine();

            Console.WriteLine("C)Karakter(Char) Veri Tipi");
            Console.WriteLine("1) char ");
            Console.WriteLine($"Minumum Değer: {(int)char.MinValue}");
            Console.WriteLine($"Maximum Değer: {(int)char.MaxValue}");
            Console.WriteLine($"Bellekteki boyutu {sizeof(char)}");
            Console.ReadLine();

            Console.WriteLine("D)Mantıksal (Bool) Veri Tipi");
            Console.WriteLine("1) bool ");
            Console.WriteLine($"Minumum Değer: {true}");
            Console.WriteLine($"Maximum Değer: {false}");
            Console.WriteLine($"Bellekteki boyutu {sizeof(bool)}");
            Console.ReadLine();

            Console.WriteLine("E)Tarih(Date) Veri Tipi");
            Console.WriteLine("1) DateTime ");
            Console.WriteLine($"Minumum Değer: {DateTime.MinValue}");
            Console.WriteLine($"Maximum Değer: {DateTime.MaxValue}");
            unsafe
            { 
            Console.WriteLine($"Bellekteki boyutu {sizeof(DateTime)}");

            }
     
            Console.ReadLine();
        }
    }
}
