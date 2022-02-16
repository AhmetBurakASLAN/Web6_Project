using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefon_Rehberi_V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            YeniKayıtFormu yeni = new YeniKayıtFormu();
            yeni.Show();
            this.Hide();

        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            btnCıkıs.PerformClick();

        }

        private void btnListe_Click(object sender, EventArgs e)
        {
            ListeFormu listeFormu = new ListeFormu();
            listeFormu.Show();
            this.Hide();
        }
    }
}
