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
    public partial class ListeFormu : Form
    {
        SqlConnection baglantı;
        string baglantiCümlesi = @"Server=DESKTOP-8M7D7GE\SQLEXPRESS;Database=sRehber;User=sa;Pwd=123";
        SqlDataAdapter adapter;
        string sorguCümlesi;
        DataTable dt;
        SqlCommand komut;
       

        void KisileriGetir()
        {
            sorguCümlesi = "SELECT * FROM tblKisiler";
            baglantı = new SqlConnection(baglantiCümlesi);
            adapter = new SqlDataAdapter(sorguCümlesi, baglantı);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvKisiler.DataSource = dt;

        }

        public ListeFormu()
        {
            InitializeComponent();
        }
        private void Liste_Load(object sender, EventArgs e)
        {
            KisileriGetir();
           
        }

        void Aktar()
        {
            
            txtAd.Text = dgvKisiler.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dgvKisiler.CurrentRow.Cells[2].Value.ToString();
            cmdCinsiyet.Text = dgvKisiler.CurrentRow.Cells[3].Value.ToString();
            txtTel.Text = dgvKisiler.CurrentRow.Cells[4].Value.ToString();

        }
        void Düzelt()
        {
            string ID = dgvKisiler.CurrentRow.Cells[0].Value.ToString();
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            char cinsiyet = ' ';
            string telNo = txtTel.Text;
            if (cmdCinsiyet.Text=="K")
            {
                cinsiyet = 'K';
            }
            else if (true)
            {
                cinsiyet = 'E';
            }
            sorguCümlesi = $"UPDATE tblKisiler SET Ad='{ad}',Soyad='{soyad}',Cinsiyet='{cinsiyet}',Telefon='{telNo}' WHERE ID='{ID}'";
            baglantı = new SqlConnection(baglantiCümlesi);
            komut = new SqlCommand(sorguCümlesi, baglantı);
            baglantı.Open();
            komut.ExecuteNonQuery();
            baglantı.Close();

        }
        void Sil()
        {
            string ID = dgvKisiler.CurrentRow.Cells[0].Value.ToString();
            sorguCümlesi = $"DELETE FROM tblKisiler WHERE ID='{ID}'";
            baglantı = new SqlConnection(baglantiCümlesi);
            komut = new SqlCommand(sorguCümlesi, baglantı);
            baglantı.Open();
            komut.ExecuteNonQuery();
            baglantı.Close();
            KisileriGetir();

        }
        private void ListeFormu_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnKapat.PerformClick();
            
        }

        private void dgvKisiler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvKisiler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Aktar();
        }

        private void btnDuzelt_Click(object sender, EventArgs e)
        {
            Düzelt();
            KisileriGetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
