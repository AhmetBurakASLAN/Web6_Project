using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_02
{
    public partial class Form1 : Form
    {
        public int hedef;
        public int puan;
        public int hak = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOyunaBasla_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            hedef = rnd.Next(100);
            puan = 50;
            hak = 5;
            btnOyunaBasla.Text = "YENİDEN";
            AktifEt();
            lblPuan.Text = puan.ToString();
            lblHak.Text = hak.ToString();
            lblMesaj.Text = "Oyun Başladı";
            lblHile.Text = hedef.ToString();
            txtSayıGiriniz.Focus();
            lblTahminler.Text = " ";

        }
        void AktifEt()
        {
            txtSayıGiriniz.Enabled = true;
            btnTahminEt.Enabled = true;
            btnOyunaBasla.Enabled = false;
        }
        void PasifEt()
        {
            txtSayıGiriniz.Enabled = false;
            btnTahminEt.Enabled = false;
            btnOyunaBasla.Enabled = true;
            btnOyunaBasla.Focus();
        }            
        void KontrolEt(int tahmin)
        {
            string sozcuk=" ";
            if (tahmin > hedef)
            {
                sozcuk = "küçük";

            }
            else if (tahmin < hedef)
            {
                sozcuk = "büyük";
            }
               

            if (tahmin != hedef)
            {
                puan -= 10;
                hak -= 1;
                lblPuan.Text = puan.ToString();
                lblHak.Text = hak.ToString();


                if (hak==0)
                {
                    
                    lblMesaj.Text = "Üzgünüm Kaybettin";
                    PasifEt();
                }else
                {
                    lblMesaj.Text = "Daha " + sozcuk + " Bir Sayı giriniz";
                }

            }
            else
            {
                lblMesaj.Text = "Tebrikler! Oyunu Kazandınız";
                PasifEt();
            }

                                              
        }

        void TahminClick()
        {
            if (txtSayıGiriniz.Text=="")
            {
                lblMesaj.Text = "Sayı giriniz.";
                
            }
            else
            {
                int tahmin = int.Parse(txtSayıGiriniz.Text);

                KontrolEt(tahmin);
                lblTahminler.Text += " " + txtSayıGiriniz.Text;
                // lblTahminler.Text = lblTahminler.Text+" " + txtSayıGiriniz.Text;
                txtSayıGiriniz.Clear();
                txtSayıGiriniz.Focus();
            }
         

        }
        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            TahminClick();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PasifEt();
        }

        private void txtSayıGiriniz_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                TahminClick();
           
            }
        }

       
    }
}
