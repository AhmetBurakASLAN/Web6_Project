using SatisProjesi.DataAccess;
using SatisProjesi.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatisProjesi
{
    public partial class Form1 : Form
    {
        SatisProjeDAL satisProjeDAL = new SatisProjeDAL();
        UrunlerDAL urunlerDAL = new UrunlerDAL();
        Satislar satislar = new Satislar();

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //cmbUrun.DisplayMember
            Refresh();
            cmbUrun.DataSource = urunlerDAL.GetAll();
            cmbUrun.DisplayMember = "UrunAd";
            cmbUrun.ValueMember = "ID";
            
        }

        public void Refresh()
        {
            dgvSatislar.DataSource = satisProjeDAL.GetAll();
        }

        public int StokMiktarıGüncelle()
        {
            int urunID = Convert.ToInt32(cmbUrun.SelectedValue.ToString());
            int eskiStok = 0;
            int guncelStok = 0;
            int satılanStok = Convert.ToInt32(cmbUrun.SelectedValue.ToString());
            eskiStok = urunlerDAL.StokMiktarıGetir($"where ID={urunID.ToString()}");
            guncelStok = eskiStok - satılanStok;
            return guncelStok;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            tblSatislar satislar = new tblSatislar
            {

                SatisTarihi = dtpSatisTarihi.Value,
                UrunID = Convert.ToInt32(cmbUrun.SelectedValue.ToString()),
                SatisAdedi = Convert.ToInt32(txtSatisAdedi.Text)

            };
            Urunler urunler = new Urunler
            {
                StokMiktari = StokMiktarıGüncelle(),
                ID = Convert.ToInt32(cmbUrun.SelectedValue.ToString())

            };
          //  urunlerDAL.Update(urunler);
            bool result = satisProjeDAL.Insert(satislar);
            if (result)
            {
                Refresh();
                MessageBox.Show("Kayıt işlemi başarıyla tamamlandı");
            }
        }
    }
}
