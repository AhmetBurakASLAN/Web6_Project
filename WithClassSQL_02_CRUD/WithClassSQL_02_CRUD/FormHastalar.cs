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
    public partial class FormHastalar : Form
    {
        VeriTabani vt = new VeriTabani();
        string sorguCümlesi;
        public FormHastalar()
        {
            InitializeComponent();
        }
        
        void Doldur()


        {
            sorguCümlesi = $"SELECT * FROM tblHastalar";
            dgvHastalar.DataSource = vt.KayitListele(sorguCümlesi);
        }
        private void FormDuzelt_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnKapat.PerformClick();

        }
        void Temizle()
        {
            txtTc.ResetText();
            txtAd.ResetText();
            txtSoyad.ResetText();
            txtAdres.ResetText();
            txtTel.ResetText();
            txtMail.ResetText();
            cmbCinsiyet.Text = "SEÇİNİZ";
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            FormAna formAna = new FormAna();
            formAna.Show();
            this.Hide();
        }

        private void btnDuzelt_Click(object sender, EventArgs e)

        {
            string ID = dgvHastalar.CurrentRow.Cells[0].Value.ToString();
            string cinsiyet = cmbCinsiyet.Text == "Kadın" ? "K" : "E";
            sorguCümlesi = $"UPDATE tblHastalar SET  TcNo='{txtTc.Text}',Ad='{txtAd.Text}',Soyad='{txtSoyad.Text}',Cinsiyet='{cinsiyet}',Adres='{txtAdres.Text}',Telefon='{txtTel.Text}' where ID='{ID}'";

            vt.Islem(sorguCümlesi);

            Doldur();
            Temizle();
        }

        private void FormDuzelt_Load(object sender, EventArgs e)
        {
            Doldur();
           
        }
        
        void Aktar()
        {
            string cinsiyet;
            string ID = dgvHastalar.CurrentRow.Cells[0].Value.ToString();
            txtTc.Text=dgvHastalar.CurrentRow.Cells[1].Value.ToString();
           txtAd.Text=dgvHastalar.CurrentRow.Cells[2].Value.ToString();
           txtSoyad.Text=dgvHastalar.CurrentRow.Cells[3].Value.ToString();
           cinsiyet= dgvHastalar.CurrentRow.Cells[4].Value.ToString();
           txtAdres.Text=dgvHastalar.CurrentRow.Cells[5].Value.ToString();
           txtTel.Text = dgvHastalar.CurrentRow.Cells[6].Value.ToString();
            txtMail.Text = dgvHastalar.CurrentRow.Cells[7].Value.ToString();
           // cmbCinsiyet.Text = cinsiyet == "K" ? "Kadın" : "Erkek"; else ifsiz
            if (cinsiyet=="K")
            {
                cmbCinsiyet.Text = "Kadın";
            }
            else if (cinsiyet == "E")
            {
                cmbCinsiyet.Text = "Erkek";
            }
        }

        private void dgvHastalar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Aktar();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string ID = dgvHastalar.CurrentRow.Cells[0].Value.ToString();
            sorguCümlesi = $"DELETE  FROM  tblHastalar  where ID='{ID}'";
            vt.Islem(sorguCümlesi);
            
            Doldur();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            FormYenikayit frmYeni = new FormYenikayit();
            frmYeni.Show();
            this.Hide();

        }
    }
}
