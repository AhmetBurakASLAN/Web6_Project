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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        class Ayakkabi
        {
            public Ayakkabi(Markalar gelenMarka)
            {
                Marka = gelenMarka;
            }
            public Ayakkabi(Markalar gelenMarka,AyakkabiTipleri gelenAyakkabiTipi)

            {
                Marka = gelenMarka;
                AyakkabiTipi = gelenAyakkabiTipi;
            }
            public Ayakkabi(Markalar gelenMarka, AyakkabiTipleri gelenAyakkabiTipi,MalzemeTipleri gelenMalzemeTİpi)

            {
                Marka = gelenMarka;
                AyakkabiTipi = gelenAyakkabiTipi;
                MalzemeTipi = gelenMalzemeTİpi;
            }
            //public string Marka { get; set; }
            public Markalar Marka { get; set; }
            public AyakkabiTipleri AyakkabiTipi { get; set; }
            public MalzemeTipleri MalzemeTipi { get; set; }

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            //Ayakkabi a = new Ayakkabi();
            //a.Marka = Markalar.Adidas;
            //a.AyakkabiTipi = AyakkabiTipleri.Çizme;
            //a.MalzemeTipi = MalzemeTipleri.ElmaDerisi;

            //MessageBox.Show($@"Marka: {a.Marka}
            //AyakkabıTipi : {a.AyakkabiTipi}
            //    Malzeme tipi: {a.MalzemeTipi}");
            Ayakkabi markasiBelliAyakkabi = new Ayakkabi(Markalar.Hummel);
            label1.Text = markasiBelliAyakkabi.Marka.ToString();
            Ayakkabi markasıVeAyakkabiTipiBelliAyakkabi = new Ayakkabi(Markalar.Puma, AyakkabiTipleri.SporAyakkabi);
            label1.Text=markasıVeAyakkabiTipiBelliAyakkabi.Marka.ToString()+" "+markasıVeAyakkabiTipiBelliAyakkabi.MalzemeTipi.ToString();

        }
       
    }
}
