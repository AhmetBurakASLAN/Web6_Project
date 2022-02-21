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
    public partial class FormRandevu : Form

    {
       
        VeriTabani vt = new VeriTabani();

        public FormRandevu()
        {
            InitializeComponent();
        }

        
        void BolumDoldur()
        {
            cmbBolum.DataSource = vt.KayitListele("SELECT * FROM tblBolumler");
            cmbBolum.DisplayMember = "BolumAd";
            cmbBolum.ValueMember = "ID";
            

        }
        void DoktorDoldur()
        {
            string bolumID = cmbBolum.SelectedValue.ToString();
            string sorguCumlesi = $"SELECT * FROM tblDoktorlar WHERE BolumID='{bolumID}'";
            lstDoktorlar.DataSource = vt.KayitListele(sorguCumlesi);
            lstDoktorlar.DisplayMember = "AdSoyad";
            lstDoktorlar.ValueMember = "ID";

        }
            
         void HastalarıDoldur()
        {
            string sorguCumlesi = $"SELECT ID,Ad,Soyad FROM tblHastalar";
            dgwHastalar.DataSource = vt.KayitListele(sorguCumlesi);


        }

        private void FormRandevu_Load(object sender, EventArgs e)
        {
            BolumDoldur();
            DoktorDoldur();
            HastalarıDoldur();
            

        }

        private void cmbBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DoktorDoldur();
            }
            catch (Exception)
            {

                
            }
        }

        private void dgwHastalar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void Kaydet()
        {
            string bolumID = cmbBolum.SelectedValue.ToString();

            string doktorID = lstDoktorlar.SelectedValue.ToString();

            string hastaID = dgwHastalar.CurrentRow.Cells[0].Value.ToString();

            string tarih = dtpTarih.Text;
            string saat = dtpSaat.Text;

            string sorguCümlesi = $"INSERT INTO tblRandevular VALUES('{bolumID}','{doktorID}','{hastaID}','{tarih}','{saat}')";
            vt.Islem(sorguCümlesi);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            string bolumAd = cmbBolum.Text;

            string doktorAd = lstDoktorlar.Text;

            string hastaAd = dgwHastalar.CurrentRow.Cells[1].Value.ToString()+""+dgwHastalar.CurrentRow.Cells[3].Value.ToString(),


            string tarih = dtpTarih.Text;

            FormOnay formOnay = new FormOnay();
            formOnay.Show();

            //Diğer formdan gelecek onaya göre kayıt yapılacak.

            Kaydet();
        }

        private void txtArananHasta_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FormRandevu_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAna formAna = new FormAna();
            formAna.Show();
            this.Hide();

        }
    }
}
