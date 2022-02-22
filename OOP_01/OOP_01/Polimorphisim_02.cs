using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OOP_01.MyClasses;

namespace OOP_01
{
    public partial class Polimorphisim_02 : Form
    {
        Sepet sepet = new Sepet();
        public Polimorphisim_02()
        {
            InitializeComponent();
        }

        private void btnTekstil_Click(object sender, EventArgs e)
        {
            Tekstil tekstil = new Tekstil("Gömlek", 300, "İpek", 3);
            sepet.Ekle(tekstil);
            dgvSepet.Rows.Add(tekstil.UrunAdi, tekstil.Fiyat, tekstil.KDVUygula());
        }

        private void btnCepTel_Click(object sender, EventArgs e)
        {
            CepTelefonu cepTelefonu = new CepTelefonu("Iphone 13 Pro",20000,"Apple");
            sepet.Ekle(cepTelefonu);
            dgvSepet.Rows.Add(cepTelefonu.UrunAdi, cepTelefonu.Fiyat, cepTelefonu.KDVUygula());

        }

        private void btnEkmek_Click(object sender, EventArgs e)
        {
            Ekmek ekmek = new Ekmek("uno", 100, "Kepekli", 400);
            sepet.Ekle(ekmek);
            dgvSepet.Rows.Add(ekmek.UrunAdi, ekmek.Fiyat, ekmek.KDVUygula());
        }
    }
}
