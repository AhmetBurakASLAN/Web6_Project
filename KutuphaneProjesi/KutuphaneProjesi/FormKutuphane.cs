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

        private void tabOdunc_Click(object sender, EventArgs e)
        {

        }

        private void FormKutuphane_Load(object sender, EventArgs e)
        {
            pnlTeslimTarihi.Visible = false;
            cmbKitapTür.DataSource = vt.KayitListele("SELECT * FROM tblTurler");
            cmbKitapTür.DisplayMember = "TurAd";
            cmbKitapTür.ValueMember = "ID";

           cmbKitapYayinEvi.DataSource = vt.KayitListele("SELECT * FROM tblYayinevleri");
           cmbKitapYayinEvi.DisplayMember = "Ad";
           cmbKitapYayinEvi.ValueMember = "ID";

            cmbKitapYazar.DataSource = vt.KayitListele("SELECT * FROM tblYazarlar");
            cmbKitapYazar.DisplayMember = "AdSoyad";
            cmbKitapYazar.ValueMember = "ID";
        }

        private void btnKitapTürKaydet_Click(object sender, EventArgs e)
        {
            Turler yeniTur = new Turler();
            yeniTur.TurAd = txtKitapTürAd.Text;
            string sorguCümlesi = "INSERT INTO tblTurler VALUES (@turAd)";

            vt.Islem(sorguCümlesi,yeniTur.TurAd);
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Kitaplar yeniKitap = new Kitaplar();
            yeniKitap.Ad = txtKitapAdi.Text;
            yeniKitap.ISBN = txtKitapISBN.Text;
            yeniKitap.SayfaSayisi = Convert.ToInt32(txtKitapSayfaSayısı.Text);
            yeniKitap.Stok = Convert.ToInt32(txtKitapStok.Text);
            yeniKitap.TurID = int.Parse(cmbKitapTür.SelectedValue.ToString());
            yeniKitap.YayinEviID = int.Parse(cmbKitapTür.SelectedValue.ToString());
            yeniKitap.YazarID =int.Parse(cmbKitapYazar.SelectedValue.ToString());

            string sorguCümlesi = "INSERT INTO tblKitaplar VALUES (@KitapISBN,@KitapAdi,@KitapSayfaSayisi,@KitapStok,@KitapTurID,@KitapYazarID,@KitapYayinEviID)";
            vt.KitapEkle(sorguCümlesi, yeniKitap.ISBN, yeniKitap.Ad, yeniKitap.SayfaSayisi, yeniKitap.Stok, yeniKitap.TurID, yeniKitap.YazarID, yeniKitap.YayinEviID);
        }

       
    }
}
