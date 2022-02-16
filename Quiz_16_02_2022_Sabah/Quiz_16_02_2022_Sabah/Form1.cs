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

namespace Quiz_16_02_2022_Sabah
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        string baglantıCümlesi = @"Server=DESKTOP-8M7D7GE\SQLEXPRESS;Database=sREhber;User=sa;Pwd=123";
        string sorguCümlesi;
        SqlDataAdapter adapter;
        DataTable dt;

      //  DESKTOP-8M7D7GE\SQLEXPRESS
        public Form1()
        {
            InitializeComponent();
        }
        
        void KisileriGetir()
        {
            sorguCümlesi = $"SELECT * FROM tblKisiler";
            baglanti = new SqlConnection(baglantıCümlesi);
            adapter = new SqlDataAdapter(sorguCümlesi, baglanti);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvKisiler.DataSource = dt;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KisileriGetir();
        }
    }
}
