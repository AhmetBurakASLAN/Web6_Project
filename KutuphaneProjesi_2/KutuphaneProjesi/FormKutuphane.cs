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

namespace KutuphaneProjesi
{
    public partial class FormKutuphane : Form
    {
        VeriTabani vt = new VeriTabani();

        public FormKutuphane()
        {
            InitializeComponent();
        }

        private void FormKutuphane_Load(object sender, EventArgs e)
        {
            //bu odunc listesini güncelliyor
            vt.TableName = "tblOdunc";
            vt.Islem();
            dgvOdunc.DataSource = vt.dt;
            //uye listesini güncelliyor
            vt.TableName = "tblUyeler";
            vt.Islem();
            dgvOUye.DataSource = vt.dt;

          

            for (int i = 0; i < dgvOUye.ColumnCount; i++)
            {
                dgvOUye.Columns[i].Visible = false;

            }
            dgvOUye.Columns[1].Visible = true;
            dgvOUye.Columns[0].Visible = true;

            //kitaplar listesini güncelliypr
            vt.TableName = "tblKitaplar";
            vt.Islem();
            dgvOKitap.DataSource = vt.dt;
            for (int i = 0; i < dgvOKitap.ColumnCount; i++)
            {
                dgvOKitap.Columns[i].Visible = false;

            }
           dgvOKitap.Columns[1].Visible = true;
            dgvOKitap.Columns[0].Visible = true;

            //Aktar();
        }
        void OduncRefresh()
        {
            vt.TableName = "tblOdunc";
            vt.Islem();
            dgvOdunc.DataSource = vt.dt;
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(dgvOdunc.CurrentRow.Cells[0].Value.ToString());
            vt.TableName = "tblOdunc";
            vt.Islem(ID);
            OduncRefresh();
        }

        private void btnOduncVer_Click(object sender, EventArgs e)
        {
            Odunc yeniOdunc = new Odunc();
            yeniOdunc.UyeID = Convert.ToInt32(dgvOUye.SelectedRows[0].Cells[0].Value.ToString());
            yeniOdunc.KitapISBN = dgvOKitap.SelectedRows[0].Cells[0].Value.ToString();
            yeniOdunc.VerilisTarihi =dtpVerilisTarihi .Value;
            yeniOdunc.Iptal = false;
            vt.TableName = "tblOdunc";
            vt.Islem(yeniOdunc);
            OduncRefresh();
            
        }

        public void Aktar()
        {
            int aranan = Convert.ToInt32(dgvOdunc.SelectedRows[0].Cells[1].Value.ToString());
            foreach (DataGridViewRow satir in dgvOUye.Rows)
            {
                DataGridViewCell hücre = satir.Cells[0];
                if (Convert.ToInt32(hücre.Value.ToString())==aranan)
                {
                    satir.Selected = true;
                    break;
                }

            }

            int aranankitap = Convert.ToInt32(dgvOdunc.SelectedRows[0].Cells[2].Value.ToString());
            foreach (DataGridViewRow satir in dgvOKitap.Rows)
            {
                DataGridViewCell hücre = satir.Cells[0];
                if (Convert.ToInt32(hücre.Value.ToString()) == aranankitap)
                {
                    satir.Selected = true;
                    break;
                }

            }
        }

        private void dgvOdunc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
        }

        private void dgvOdunc_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Aktar();
            }
            catch (Exception)
            {

              //  throw;
            }
        }
    }
}
