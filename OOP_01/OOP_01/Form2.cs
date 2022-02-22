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

    class Ogrenci
    {
      //
  
      /// <summary>
      /// Bu overloadı kullanırsan varsayılan
      /// </summary>
        public Ogrenci() //Constructur Medhot(yapıcı metod)
        {
            yas = 15;

       }
        public Ogrenci(short gelenyas)// construvt 
        {
            //this.yas = yas;
            yas = gelenyas;
        }
        string ad;
        short yas;
        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        public short Yas
        {
            get { return yas; }
            set { yas = value; }
        }
    }

    public class Ayakabi

    {
        
        private char cinsiyet;

        public char Cinsiyet

        {
            set {  cinsiyet= value; }
        }

        public  Ayakabi()
        {
            marka = "Adidas";

        }
        private string marka;

        public string Marka
        {
            get { return Marka; }
           // set { Marka = value; }
        }

        private int numara;

        public int Numara
        {
            get { return Numara; }
            set { Numara = value; }
        }

    }
        
    public partial class Form2 : Form
    {
        

        
            

public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Ogrenci ogrenci1 = new Ogrenci();
            //ogrenci1.Ad = "Engin";
            //Ogrenci ogrenci2 = new Ogrenci();
            //ogrenci2.Ad = "Umay";
            //Ogrenci ogrenci3 = new Ogrenci();
            //MessageBox.Show(ogrenci3.Yas.ToString);
            //Ogrenci ogrenci4 = new Ogrenci();
            //                      MessageBox.Show($"Adı: {ogrenci1.Ad}\n yaşı {ogrenci1.Yas};


           // Ayakabi ayakabi1 = new Ayakabi();
            ///ayakabi1.Numara = 42;
           // ayakabi1.Marka = "Puma";
                
        }
    }
}
