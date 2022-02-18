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
    public partial class Doktorlar : Form
    {
        VeriTabani vt = new VeriTabani();

        public Doktorlar()
        {
            InitializeComponent();
        }

        private void Doktorlar_Load(object sender, EventArgs e)
        {
            cmbBolum.DataSource = vt.KayitListele("SELECT * FROM tblBolumler");
            cmbBolum.DisplayMember = "BolumAd";
            cmbBolum.ValueMember = "ID";
        }

        private void cmbBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string sorguCümlesi = $"INSERT INTO tblDoktorlar VALUES ('{txtSicilNo.Text}'," +
                $"'{txtAdSoyad.Text}','{txtTel.Text}','{txtMail.Text}'," +
                $"'{cmbBolum.SelectedValue.ToString()}')";
            vt.Islem(sorguCümlesi);
        }

        
    }
}
