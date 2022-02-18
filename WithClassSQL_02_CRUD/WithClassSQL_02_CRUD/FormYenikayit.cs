using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WithClassSQL_02_CRUD
{
    public partial class FormYenikayit : Form
    {
        VeriTabani vt = new VeriTabani();
        string sorguCümlesi;
        public FormYenikayit()
        {
            InitializeComponent();
        }

        void Temizle()
        {
            txtTC.ResetText();
            txtAd.ResetText();
            txtSoyad.ResetText();
            txtAdres.ResetText();
            txtTel.ResetText();
            txtMail.ResetText();
            cmbCinsiyet.Text = "SEÇİNİZ";

        }
        private void FormYenikayit_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormHastalar formHastalar = new FormHastalar();
            formHastalar.Show();
            this.Hide();
        }
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string cinsiyet = cmbCinsiyet.Text == "Kadın" ? "K" : "E";
            //sorguCümlesi = $"INSERT INTO tblHastalar(TcNo,Ad,Soyad,Cinsiyet) VALUES ('{txtTC.Text}','{txtAd.Text}','{txtSoyad.Text}','{cinsiyet}')"; sadece girdirmek istediklerinde kullanılır
            sorguCümlesi = $"INSERT INTO tblHastalar VALUES ('{txtTC.Text}','{txtAd.Text}','{txtSoyad.Text}','{cinsiyet}','{txtAdres.Text}','{txtTel.Text}','{txtMail.Text}')";

            vt.Islem(sorguCümlesi);
            Temizle();
        }

        private void FormYenikayit_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Text = "SEÇİNİZ";
        }
    }
}
