using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form01_TemelKontroller
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        void EKLE()
        {
            lstKisiler.Items.Add(txtAdSoyad.Text.ToUpper().Trim());
            txtAdSoyad.ResetText();
            txtAdSoyad.Focus();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            EKLE();

        }

        private void txtAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {

            string adSoyad = txtAdSoyad.Text;
            int uzunluk = adSoyad.Length;
            
            if (uzunluk>=1)
            {
                int konum = uzunluk-1;
                if (adSoyad[konum].ToString() == " ")
                {
                    e.Handled = e.KeyChar == (char)Keys.Space;
                }
                
            }
            else
            {
                e.Handled = e.KeyChar == (char)Keys.Space;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                EKLE();

            }
            
            
        }

        private void btnSay_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Kisi Sayısı: {lstKisiler.Items.Count}");

        }

        void Arama()
        {
            string aranan = txtAranan.Text.ToUpper();
            if (lstKisiler.Items.Contains(aranan))
            {
                lblBulunan.Text = aranan;
            }
            else
            {
                lblBulunan.Text = "Aradığınız kayıt bulunamadı.";
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {

            /*string aranan = txtAranan.Text.ToUpper();
            if (lstKisiler.Items.Contains(aranan))
            {
                lblBulunan.Text = aranan;
            }
            else
            {
                lblBulunan.Text = "Aradığınız kayıt bulunamadı.";
            }
            */
            Arama();

        }

        private void txtAranan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Arama();
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
