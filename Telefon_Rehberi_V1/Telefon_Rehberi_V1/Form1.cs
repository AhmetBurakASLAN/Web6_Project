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

namespace Telefon_Rehberi_V1
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlDataAdapter adapter;
        DataTable dt;
        SqlCommand komut;
        string baglantiCümlesi = @"Server=DESKTOP-8M7D7GE\SQLEXPRESS;Database=sRehber;User=sa;Pwd=123";
        string sorguCümlesi;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KisileriGetir();
        }
        void KisileriGetir()
        {
            sorguCümlesi = "SELECT * FROM tblKisiler";
            baglanti = new SqlConnection(baglantiCümlesi);
            adapter = new SqlDataAdapter(sorguCümlesi,baglanti);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvKisiler.DataSource = dt;

        }

        void Aktar()
        {
            //dgv kişiler üzeirnde tıklandığında ,yan tarafa ilgili kaydı getirecek

            lblId.Text = dgvKisiler.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dgvKisiler.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dgvKisiler.CurrentRow.Cells[2].Value.ToString();
            if (dgvKisiler.CurrentRow.Cells[3].Value.ToString()=="K")
            {
                rdbKadin.Checked = true;

            }
            else
            {
                rdbErkek.Checked = true;

            }
            txtTel.Text = dgvKisiler.CurrentRow.Cells[4].Value.ToString();

        }
        void Düzelt()
        { string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            char cinsiyet;
            if (rdbKadin.Checked==true)
            {
                cinsiyet = 'K';

            }
            else
            {
                cinsiyet = 'E';

            }
            string tel = txtTel.Text;
            String ID = lblId.Text;
            sorguCümlesi = $"update tblKisiler SET AD='{ad}',Soyad='{soyad}',Cinsiyet='{cinsiyet}',Telefon='{tel}' where ID='{ID}'";
            baglanti = new SqlConnection(baglantiCümlesi);
            komut = new SqlCommand(sorguCümlesi, baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KisileriGetir();
        }
        private void dgvKisiler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Aktar();
        }

        private void btnDuzelt_Click(object sender, EventArgs e)
        {
            Düzelt();
        }
    }
}
