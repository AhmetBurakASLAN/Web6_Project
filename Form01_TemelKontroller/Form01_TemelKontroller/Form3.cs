using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form01_TemelKontroller
{
    public partial class Form3 : Form
    {
        public string cinsiyet = " ";
        public Form3()
        {
            InitializeComponent();
        }

        string CinsiyetBelirle()
        {
            if (rdbKadın.Checked==true)
            {
                return "Kadın";

            }
            else
            {

                return "Erkek";
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        void Ekle()
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = txtAdSoyad.Text; // lvlnin text özelliği 1.kolon demektir.
            lvi.SubItems.Add(CinsiyetBelirle());
            lsvKisiler.Items.Add(lvi);
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ekle();
        }
    }

}
