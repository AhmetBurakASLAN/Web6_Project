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
    public partial class FormAna : Form
    {
        
        public FormAna()
        {
            InitializeComponent();
        }

        
        //ekrandan datagrid viewi çıkardğımız için buna gerek kalmadı.
        ////void Doldur()
        ////{

        ////    sorguCümlesi = $"SELECT * FROM tblHastalar";
        ////    dgvHastalar.DataSource = vt.KayitListele(sorguCümlesi);
        ////}
       
                
      
        

        private void FormAna_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnKapat.PerformClick();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
           sy
           //Application.Exit();
        }

        private void btnHastalar_Click(object sender, EventArgs e)
        {
            FormHastalar formHastalar = new FormHastalar();
            formHastalar.Show();
            this.Hide();
            
        }

        private void btnBolumler_Click(object sender, EventArgs e)
        {
            FormBolumler formbolumler = new FormBolumler();
            formbolumler.Show();
            this.Hide();
        }

        private void btnRandevu_Click(object sender, EventArgs e)
        {
            FormRandevu formrandevu = new FormRandevu();
            formrandevu.Show();
            this.Hide();
        }
    }
}
