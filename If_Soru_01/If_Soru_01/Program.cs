using System;

namespace If_Soru_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir öğrencinin not ortalaması 
            //60 ve üzerinde ise öğrenci başarılı değilse başarısız kabul ediliyor
            //öğrencinin ortalaması vize ve final notları üzerinden şu şekilde hesaplanıyor
            //vizenin %40'ı ve final notunun %60' alınıyoru
            //bu duruma göre vize ve final notları klavyeden girilen bir öğrencinin not ortalamasını ve başarılı olma 
            //durumunu yazdıran programı yazınız.

            //Console.Write(" Vize notunu giriniz : ");

            //int vize = Convert.ToInt32(Console.ReadLine());
            //Console.Write(" Final notunu giriniz : ");

            //int final = Convert.ToInt32(Console.ReadLine());
            //double not_ortalaması ;
            //not_ortalaması = (final *0.6)+(vize*0.4);



            //if (not_ortalaması>=60)
            //{
            //    Console.WriteLine($"not ortalaması: {not_ortalaması}, BAŞARILI");

            //}
            //else
            //{
            //    Console.WriteLine($"not ortalaması: {not_ortalaması} BAŞARISIZ");
            //}


            /*
             * bir mağazadan alınan ürünün fiyatı 100 liradan 
             * *büyük ya da eşitse 5 lira olan kargo ücreti alınmamaktadır.
             * gereken tutarı bulup ekrana yazdıran programı yazınız
            */

            //Console.Write(" ürünün fiyatını giriniz : ");
            //double price = Convert.ToDouble(Console.ReadLine());
            //if (price>100.0)
            //{
            //    Console.WriteLine($" ödemeniz gerekn tutar: {not_ortalaması+5} ");
            //}
            //else
            //{
            //    Console.WriteLine($" ödemeniz gerekn tutar: {not_ortalaması + 5} ");
            //}

            //Console.ReadLine();

            /*klavyeden girilecek iki ürünün fiyatının toplamı 200 lira ve üzerinde ise 
             * ikinci üründen %30 indirim yapılması gerekmektedir. Buna göre iki ürün fiyatını 
             * girdiren ve gerekli hesaplamayı yapıp toplamları ekranda gösteren programı yazınız
             */
            /*Console.Write(" 1.ürün fiyatı giriniz : ");
            double fiyat1 = Convert.ToDouble(Console.ReadLine());
            Console.Write(" 2.ürün fiyatı giriniz : ");
            Double fiyat2 = Convert.ToDouble(Console.ReadLine());
            

            double toplam = fiyat1 + fiyat2;
            if (toplam>=200)
            {
                double yeni_toplam =fiyat1+fiyat2*0.7;

                Console.WriteLine($"toplam tutar= {yeni_toplam}");
            }
            else
            {
                Console.WriteLine($"toplam tutar= {toplam}");
            }
            Console.ReadLine();
            */
            //Bir öğrencinin not ortalaması 
            //60 ve üzerinde ise öğrenci başarılı değilse başarısız kabul ediliyor
            //öğrencinin ortalaması vize ve final notları üzerinden şu şekilde hesaplanıyor
            //vizenin %40'ı ve final notunun %60' alınıyoru
            //bu duruma göre vize ve final notları klavyeden girilen bir öğrencinin not ortalamasını ve başarılı olma 
            //durumunu yazdıran programı yazınız.
            /*ayrıca öğrencinin devamsızlık sınırı 10 gündür,
             * klavyeden girilen devamsızlık notları kalıp kalmadığını yazın
            */
            /*Console.Write(" Devamsızlık durumunu giriniz : ");
            int devamsızlık = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Vize notunu giriniz : ");
            int vize = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Final notunu giriniz : ");

            int final = Convert.ToInt32(Console.ReadLine());
            double not_ortalaması;
            not_ortalaması = (final * 0.6) + (vize * 0.4);



            if (not_ortalaması >= 60 && devamsızlık < 10)
            {
                Console.WriteLine($"DERSİ GEÇTİ");

            }
            else
            {
                Console.WriteLine($" DERSTEN KALDI");
            }

            */
            /*
             * bu yanlış program......doğrusu asagıda
            Console.Write("birinci ürün tutarı girin: ");
            double fiyat1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("ikinci ürün tutarı girin: ");
            double fiyat2 = Convert.ToDouble(Console.ReadLine());

            double toplam = fiyat1 + fiyat2;
            double toplamInd=0;
            double indirim;
            if (toplam>200)
            {
                toplamInd = fiyat1 + fiyat2 * 0.65;
            }

            if (toplam>200 && toplamInd < 250)
            {
                toplamInd=toplamInd+25;
                indirim = fiyat2 * 0.35;
                
                Console.WriteLine($"genel tutar : {toplam}");
                Console.WriteLine($"indirimli tutar: {indirim}");
                Console.WriteLine("kargo bedeli=25 TL");
                Console.WriteLine($"ödenecek  tutar: {toplamInd}");
            }
            else if (toplam > 200 && toplamInd >= 250)
            {
               
                indirim = fiyat2 * 0.35;

                Console.WriteLine($"genel tutar : {toplam}");
                Console.WriteLine($"indirimli tutar: {indirim}");
                Console.WriteLine("kargo bedeli=0 TL");
                Console.WriteLine($"ödenecek  tutar: {toplamInd}");
            }
            else
            {
                toplam = toplam + 25;
                Console.WriteLine($"genel tutar : {toplam}");
                Console.WriteLine($"indirimli tutar: 0 TL");
                Console.WriteLine("kargo bedeli=25 TL");
                Console.WriteLine($"ödenecek  tutar: {toplam}");
            }
            Console.ReadLine();
            */
            double indirimliTutar = 0;
            double kargoUcreti = 0;
            Console.Write("Ürün 1'in fiyatı: ");
            double urun1 = double.Parse(Console.ReadLine());
            Console.Write("Ürün 2'in fiyatı: ");
            double urun2 = double.Parse(Console.ReadLine());
            double genelTutar = urun1 + urun2;

            if (genelTutar>=200)
            {
               indirimliTutar = genelTutar - urun2 * 0.35;

            }
            else
            {
                indirimliTutar = genelTutar;
            }
            if (indirimliTutar>=250)
            {
                kargoUcreti = 0;
            }
            double ödenecekTutar = indirimliTutar + kargoUcreti;
            Console.WriteLine($"Genel Tutar     :{genelTutar}");
            Console.WriteLine($"İndirimli Tutar    :{indirimliTutar}");
            Console.WriteLine($"Kargo Bedeli     :{kargoUcreti}");
            Console.WriteLine($"{}ödenecek tutar");

        }
    }
}