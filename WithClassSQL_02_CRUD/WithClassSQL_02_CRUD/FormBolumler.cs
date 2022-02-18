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
    public partial class FormBolumler : Form
    {
        VeriTabani vt = new VeriTabani();
          string sorguCümlesi;
            
        public FormBolumler()
        {
            InitializeComponent();
        }
        void Tazele()
        {

            string sorguCümlesi = "SELECT * FROM tblBolumler";
            dgvBolumler.DataSource = vt.KayitListele(sorguCümlesi);


        }
        private void FormBolumler_Load(object sender, EventArgs e)
        {

            Tazele();
        }

        private void dgvBolumler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtBolumler.Text = dgvBolumler.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string ID = dgvBolumler.CurrentRow.Cells[0].Value.ToString();
            sorguCümlesi = $"UPDATE tblBolumler Set BolumAd='{txtBolumler.Text}' where ID='{ID}'";
                vt.Islem(sorguCümlesi);
            Tazele();
            

        }

        private void FormBolumler_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAna formAna = new FormAna();
            formAna.Show();
            this.Hide();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            string ID = dgvBolumler.CurrentRow.Cells[0].Value.ToString();
            sorguCümlesi = $"DELETE FROM tblBolumler where ID = '{ID}'";
            vt.Islem(sorguCümlesi);
            Tazele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            
            if (sayac==1)
            {
                btnKaydet.Text = "btnKaydet";
                sayac++;
            }
            else if (sayac==2)
            {
                sorguCümlesi = $"INSERT INTO tblBolumler VALUES ('{txtBolumler.Text}')";
                vt.Islem(sorguCümlesi);
                Tazele();
                txtBolumler.Clear();
                btnKaydet.Text = "Yeni";
                sayac = 0;
            }
            
                
        }
    }
}
