using PersonelTakipUygulaması.DataAccess;
using PersonelTakipUygulaması.Entities;
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
        int secilenID = 0;
        Calisan calisan = null;

        public FormAna()
        {
            InitializeComponent();
        }

        private void FormAna_Load(object sender, EventArgs e)
        {
            Refresh();
            Transfer();
        }
        void Transfer()
        {
           
            try
            {
                secilenID = Convert.ToInt32(dgvCalisanlar.SelectedRows[0].Cells[0].Value.ToString());
                txtAd.Text = dgvCalisanlar.SelectedRows[0].Cells[1].Value.ToString();
                txtSoyad.Text = dgvCalisanlar.SelectedRows[0].Cells[2].Value.ToString();
                txtTcNo.Text = dgvCalisanlar.SelectedRows[0].Cells[3].Value.ToString();
                txtPersonelNo.Text = dgvCalisanlar.SelectedRows[0].Cells[4].Value.ToString();
                dtpDogumTarihi.Value = Convert.ToDateTime(dgvCalisanlar.SelectedRows[0].Cells[5].Value.ToString());
                dtpIseBaslamaTarihi.Value = Convert.ToDateTime(dgvCalisanlar.SelectedRows[0].Cells[6].Value.ToString());
                cmbDepartman.Text = dgvCalisanlar.SelectedRows[0].Cells[7].Value.ToString();
                cmbUnvan.Text = dgvCalisanlar.SelectedRows[0].Cells[8].Value.ToString();
                cmbDurumu.Text = dgvCalisanlar.SelectedRows[0].Cells[9].Value.ToString();
            }
            catch (Exception)
            {

               // throw;
            }
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

                dtpDogumTarihi.Format = DateTimePickerFormat.Custom;
                dtpDogumTarihi.CustomFormat = " ";
               dtpIseBaslamaTarihi.Format = DateTimePickerFormat.Custom;
               dtpIseBaslamaTarihi.CustomFormat = " ";
                txtAd.Focus();
                Refresh();
                Cancel();
                
            }
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            ClearTools();
        }

        private void dtpDogumTarihi_ValueChanged(object sender, EventArgs e)
        {
            dtpDogumTarihi.Format = DateTimePickerFormat.Long;

        }

        private void dtpIseBaslamaTarihi_ValueChanged(object sender, EventArgs e)
        {
            dtpIseBaslamaTarihi.Format = DateTimePickerFormat.Long;

        }

    

        private void dgvCalisanlar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Transfer();
        }

        void Refresh()
        {
            dgvCalisanlar.DataSource = calisanDal.GetAll();
        }
        bool BlankControl()
        {
            bool result = true;
            foreach (Control control in pnlAraclar.Controls)
            {
                if (control.Text==string.Empty|| control.Text==" ")
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!BlankControl())
            {
                MessageBox.Show("lütfen alanları doldurun");
            }
            else
            {
                calisan = new Calisan
                {
                    Ad = txtAd.Text,
                   Soyad = txtSoyad.Text,
                    TcNo = txtTcNo.Text,
                     PersonelNo = txtPersonelNo.Text,
                    DogumTarihi = dtpDogumTarihi.Value,
                    IseBaslamaTarihi = dtpIseBaslamaTarihi.Value,
                    Unvan = cmbUnvan.SelectedItem.ToString(),
                  Departman = cmbDepartman.SelectedItem.ToString(),
                   Durumu = cmbDurumu.SelectedItem.ToString()
                };
                bool result = Convert.ToBoolean(calisanDal.Insert(calisan));
                if (result)
                {
                    MessageBox.Show("KAYDETTİ");
                }
                Refresh();
                ClearTools();
            }
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            
            if (secilenID==0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz kaydı seçiniz");

            }
            else
            {
                DialogResult answer = MessageBox.Show("Seçilen Kayıt silincektir\n emin misiniz?","DİKKAT!",MessageBoxButtons.YesNo);
                if (answer==DialogResult.Yes)
                {
                    bool result = calisanDal.Delete(secilenID);
                    if (result)
                    {
                        Refresh();
                        MessageBox.Show($"{secilenID} ID'li kayıt slinmiştir.");
                    }
                }
            }


        }

        void Cancel()
        {
            dgvCalisanlar.ClearSelection();
            secilenID = 0;
        }  
        private void btnHepsiniSil_Click(object sender, EventArgs e)
        {
           
                DialogResult answer = MessageBox.Show("Bütün kayıtlar silenecektir \n Emin Misin", "Dikkat",MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {
                    bool result = calisanDal.Delete();
                    if (result)
                    {
                        Refresh();
                        MessageBox.Show("Bütün kayırlr silinecektir");
                    }
                }
            
           ///sadece seçili kayıtları silecek kayıtları yazınız.

        }

        private void dgvCalisanlar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Escape)//Baılan tuş escape ise
            {
                Cancel();
            }
        }

        string CreateQueryString()
        {
            string queryString =string.Empty;
            List<string> alanlar = new List<string>();
            foreach (Control control in pnlAraclar.Controls)
            {
                if (control.Tag == null) continue;

                if (String.IsNullOrEmpty(control.Text) || control.Text == " ") continue;
                string fieldName = control.Tag.ToString();
                    string value = string.Empty;
                    
                
                //wehere fieldname= value//
                if (control.GetType()==typeof(DateTimePicker))
                {
                    value = Convert.ToDateTime(control.Text).ToString("yyyy-MM-dd");
                    alanlar.Add($"{fieldName}='{value}'");
                }
                else
                {
                    value = control.Text;
                    if (cbxBenzer.Checked)
                    {
                        alanlar.Add($"{fieldName} LIKE '%{value}%'");
                    }
                    else
                    {
                    alanlar.Add($"{fieldName}='{value}'");

                    }
                    
                }
                
                if (alanlar.Count>0)
                {
                    queryString = $"WHERE {string.Join(" and ", alanlar)}";
                }
                
            }
            return queryString;
        }
        
	

        private void btnBul_Click(object sender, EventArgs e)
        {
            dgvCalisanlar.DataSource = calisanDal.GetAll(CreateQueryString()) ;
        }
    }
}
