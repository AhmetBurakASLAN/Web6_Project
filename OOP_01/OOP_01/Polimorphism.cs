using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_01
{
    public partial class Polimorphism : Form
    {
        
        class Urun
        {
            public string UrunAdi { get; set; }
            public double Fiyat { get; set; }
            public virtual double KDVUygula()
            {
                return Fiyat * 1.08; //default olarak %8 kdv uygulanıyor.
            }
            
            
            public Urun()
            {

            }                
            public Urun(string uAd,double uFiyat)
            {
                UrunAdi = uAd;
                Fiyat = uFiyat;
            }

        }
        class Tekstil :Urun
        {
            public string KumasTuru { get; set; }
            public short Beden { get; set; }
            public string UreticiFirma { get; set; }
            public Tekstil(string tAd,double tfiyat,string tKumasTuru,short tBeden)
            {
                UrunAdi = tAd;
                Fiyat = tfiyat;
                KumasTuru = tKumasTuru;
                Beden = tBeden;
            }
        }
        class CepTelefonu : Urun
        {
            public string Ozellikler { get; set; }
            public string Marka { get; set; }
            public CepTelefonu(string cAd,double cFiyat,string cMarka)
            {
                UrunAdi = cAd;
                Fiyat = cFiyat;
                Marka = cMarka;

                    
            }
        }
        class Ekmek :Urun
        {
            public string EkmekTuru { get; set; }
            public double Gramaj { get; set; }
            public Ekmek (string cAd,double cFiyat,string cEkmekTuru,double cGramaj)
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
        class Sepet
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

        }





        public Polimorphism()
        {
            InitializeComponent();
        }
       

        private void Polimorphism_Load(object sender, EventArgs e)
        {
            Sepet sepet = new Sepet();
            Ekmek ekmek = new Ekmek("Uno", 10, "Tava", 220);
            Tekstil tekstil = new Tekstil("Pantolon", 135, "Keten", 42);
            Tekstil tekstil1=new Tekstil("Hırka",195,"İpek",46);
            CepTelefonu cepTelefonu = new CepTelefonu("Galaxy A3", 4900, "Samsung");
            sepet.Ekle(tekstil);
            sepet.Ekle(tekstil1);
            sepet.Ekle(cepTelefonu);
            sepet.Ekle(ekmek);
            MessageBox.Show($"Sepetteki Ürünlerim toplam tutarı{sepet.ToplamTutar().ToString()}");
            
        }
    }
}
