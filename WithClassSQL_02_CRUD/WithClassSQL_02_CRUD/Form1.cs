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
        VeriTabani vt = new VeriTabani();
        public FormAna()
        {
            InitializeComponent();
        }

        void Doldur()
        {


            dgvHastalar.DataSource = vt.HastalariListele();
        }
       

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            FormYenikayit frmYeni = new FormYenikayit();
            frmYeni.Show();

        }

        private void FormAna_Activated(object sender, EventArgs e)
        {
            Doldur();
        }

        private void FormAna_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void btnDuzelt_Click(object sender, EventArgs e)
        {
            FormDuzelt formDuzelt = new FormDuzelt();
            formDuzelt.Show();
                this.Hide();
        }

        private void FormAna_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnKapat.PerformClick();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
    }
}
