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
    public partial class FormOnay : Form
    {
        public FormOnay(string bolumAd, string hastaAd,, string doktorAd, string tarih)
        {

            InitializeComponent();

                 string bolumAd1=bolumAd;
                string hastaAd1=hastaAd;
                string doktorAd1=doktorAd;
                string tarih1=tarih;
            
        }

        private void FormOnay_Load(object sender, EventArgs e)
        {
            FormRandevu frmR = new FormRandevu();
            
        }
    }
}
