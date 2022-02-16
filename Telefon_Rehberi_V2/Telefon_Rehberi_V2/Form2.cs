using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefon_Rehberi_V2
{
    public partial class YeniKayıtFormu : Form
    {
        string sorguCümlesi;
        string baglantiCümlesi=@"Server=DESKTOP-8M7D7GE\SQLEXPRESS;Database=sRehber;User=sa;Pwd=123";
        SqlCommand komut;
        SqlConnection baglanti;

        public YeniKayıtFormu()
        {
            InitializeComponent();
        }

        private void YeniKayıtFormu_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnKapat.PerformClick();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Form1 anaform = new Form1();

            anaform.Show();
            this.Hide();
            
        }
        void Ekle()
        {
            string ad = txtAd.Text;
            string soyAd = txtSoyad.Text;
            char cinsiyet=' ';
            if (cmbCinsiyet.Text=="Kadın")
            {
                cinsiyet = 'K';

            }
            else if(cmbCinsiyet.Text=="Erkek")
            {
                cinsiyet = 'E';
            }
            string tel = txtTel.Text;
            sorguCümlesi = $"INSERT INTO tblKisiler Values('{ad}','{soyAd}','{cinsiyet}','{tel}')";
            baglanti = new SqlConnection(baglantiCümlesi);
            komut = new SqlCommand(sorguCümlesi,baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
                        
        }

        void Temizle()
        {
            txtAd.ResetText();
            txtSoyad.ResetText();
            txtTel.ResetText();
            cmbCinsiyet.ResetText();
         
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Ekle();
            Temizle();
        }

        private void YeniKayıtFormu_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.SelectedIndex = 0;
        }
    }
}
