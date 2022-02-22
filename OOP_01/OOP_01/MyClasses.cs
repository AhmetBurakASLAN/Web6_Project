using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_01
{
    class MyClasses
    {


        public class Urun
        {
            public string UrunAdi { get; set; }
            public double Fiyat { get; set; }
            public virtual double KDVUygula()
            {
                return Fiyat * 1.1; //default olarak %8 kdv uygulanıyor.
            }


            public Urun()
            {

            }
            public Urun(string uAd, double uFiyat)
            {
                UrunAdi = uAd;
                Fiyat = uFiyat;
            }

        }
        public class Tekstil : Urun
        {
            public string KumasTuru { get; set; }
            public short Beden { get; set; }
            public string UreticiFirma { get; set; }
            public Tekstil(string tAd, double tfiyat, string tKumasTuru, short tBeden)
            {
                UrunAdi = tAd;
                Fiyat = tfiyat;
                KumasTuru = tKumasTuru;
                Beden = tBeden;
            }
        }
        public class CepTelefonu : Urun
        {
            public string Ozellikler { get; set; }
            public string Marka { get; set; }
            public CepTelefonu(string cAd, double cFiyat, string cMarka)
            {
                UrunAdi = cAd;
                Fiyat = cFiyat;
                Marka = cMarka;


            }
        }
        public class Ekmek : Urun
        {
            public string EkmekTuru { get; set; }
            public double Gramaj { get; set; }
            public Ekmek(string cAd, double cFiyat, string cEkmekTuru, double cGramaj)
            {
                UrunAdi = cAd;
                Fiyat = cFiyat;
                EkmekTuru = cEkmekTuru;
                Gramaj = cGramaj;


            }
            public double KDVUygula()
            {
                return Fiyat * 1.01;
            }
        }
        public class Sepet
        {
            List<Urun> urunler = new List<Urun>();
            public double ToplamTutar()
            {
                double toplamFiyat = 0;
                foreach (Urun item in urunler)
                {
                    toplamFiyat += item.KDVUygula();
                }
                return toplamFiyat;
            }

            public void Ekle(Urun yeniUrun)
            {
                urunler.Add(yeniUrun);
            }

            //******************************************************

            
                     








        }

        //Özel dders uygulaması
        /* Üç üyelik paketi (stndart üyelik , pro üyelik ve elit üyelik)
         * 
         * standart olarak her üyede olması gerekn özellikler : ----------
         * ad-soyad ,
         * kullanıcı adı, 
         * bransı(matematik,fizik,kimya,türkçe),
         * yaşı
         * deneyim süresi
         * herkese acık olmayacak şekilde telefon numarası
         * 
         * Pro üyelerde olması gerekn özellikler-----------
         * standart öxelliklere ek olarak 
         * onaylı uye oldugunu gösteren rozet
         * ana sayfada görüntülenme
         * Herkese açık telefon numarası
         * Ders almak isteyenlere direkt erişmek(metot)
         * 
         * Elit üyelerde olması gereken özellikler--------------
         * standart + pro özelliklere ek olarak aşağıdaki özellikleri
         * Arama Sonuclarında üstte yer alma(metot)
         * Önerilme(metot)
         */

        public class StandartUyelik
        {

            public string AdSoyad { get; set; }
            public string KullaniciAdi { get; set; }
            public Branslar Brans { get; set; }
            public int Yas { get; set; }
             int Telefon { get; set; }
            public int Deneyim { get; set; }
            public StandartUyelik()
            {

            }
            public StandartUyelik(string sAdSoyad, string sKullaniciAdi, Branslar sbranslar, int sYas, int sDeneyim)

            {
                AdSoyad = sAdSoyad;
                KullaniciAdi = sKullaniciAdi;
                Brans = sbranslar;
                Yas = sYas;
                Deneyim = sDeneyim;

            }


        }

        public class ProUyelik : StandartUyelik
        {
            public string Rozet { get; set; }
            public string AnaSayfadaGorntulenme { get; set; }
            public int Telno { get; set; }
            public bool Erisim { get; set; }

            public bool  Erişim()
            {
                Erisim = true;
                return Erisim;
            }

            public ProUyelik()
            {

            }
            public ProUyelik(string pAdSoyad, string pKullaniciAdi, Branslar pbranslar, int pYas, int pDeneyim,string pRozet,string pAnaSayfadaGorüntülenme,int pTel,bool pErisim)
            {
                AdSoyad = pAdSoyad;
                KullaniciAdi = pKullaniciAdi;
                Brans = pbranslar;
                Yas = pYas;
                Deneyim = pDeneyim;
                Rozet = pRozet;
                AnaSayfadaGorntulenme = pAnaSayfadaGorüntülenme;
                Telno = pTel;
                Erisim = pErisim;

            }
        }

        public class ElitUyelik:ProUyelik
        {
            public bool AramaOzelligi { get; set; }
            public bool OnerilmeOzelligi { get; set; }
            public bool Arama()
            {
                AramaOzelligi = true;
                return AramaOzelligi;
            }
            public bool Onerilme()
            {
                OnerilmeOzelligi = true;
                return OnerilmeOzelligi;

            }

            public ElitUyelik()
            { 

            }
           
                public ElitUyelik(string eAdSoyad, string eKullaniciAdi, Branslar ebranslar, int eYas, int eDeneyim, string eRozet, string eAnaSayfadaGorüntülenme, int eTel, bool eErisim,bool eAramaOzelligi,bool eOnerilmeOzellig)
                {
                    AdSoyad = eAdSoyad;
                    KullaniciAdi = eKullaniciAdi;
                    Brans = ebranslar;
                    Yas = eYas;
                    Deneyim = eDeneyim;
                    Rozet = eRozet;
                    AnaSayfadaGorntulenme = eAnaSayfadaGorüntülenme;
                    Telno = eTel;
                    Erisim = eErisim;
                AramaOzelligi = eAramaOzelligi;
                On

                }
            }
        }
    }
}
