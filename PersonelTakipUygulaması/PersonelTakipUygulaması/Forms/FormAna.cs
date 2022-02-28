using PersonelTakipUygulaması.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipUygulaması
{
    public partial class FormAna : Form
    {
        CalisanDAL calisanDal = new CalisanDAL();
        public FormAna()
        {
            InitializeComponent();
        }

        private void FormAna_Load(object sender, EventArgs e)
        {
            dgvCalisanlar.DataSource= calisanDal.GetAll("WHERE Durumu='AKTİF'");
        }

       void ClearTools()
        {
            foreach (Control control in pnlAraclar.Controls)
            {
                if (control.GetType()!=typeof(Label)) // sıradaki control label değilse
                {
                    control.Text = string.Empty;
                }

                //çalışma sorusu 
                //date time 
            }
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            ClearTools();
        }
    }
}
