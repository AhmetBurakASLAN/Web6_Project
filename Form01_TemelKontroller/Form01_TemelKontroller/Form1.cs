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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSayi_TextChanged(object sender, EventArgs e)
        {
           // lblSayi.Text = txtSayi.Text;
        }

        private void txtSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
             if (e.KeyChar.ToString()=="A")
             {
                 MessageBox.Show("Büyük A harfine bastınız");
             }else
             {
                 MessageBox.Show("Olmadı yar ,su testisine dolmadı yar");

             }
            
            if (char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Bİr rakama  bastınız");

            }
            else
            {
                MessageBox.Show("Rakam dışında birşey yazdınız");
            }
            
            if (!(char.IsDigit(e.KeyChar)||e.KeyChar==(char)Keys.Back))
            {
                e.Handled = true;
            }
            */
        }
            
        private void txtHarf_KeyPress(object sender, KeyPressEventArgs e)
        {

            //Isletter harf olup olmadığını denetler
            //  if (!(char.IsLetter(e.KeyChar)|| e.KeyChar==(char)Keys.Back))
            //   {
            //      e.Handled = true;
            //   }
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtBuyukHarf_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsUpper(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        void Doldur()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Mobil Programlama");
            comboBox1.Items.Add("Web Programlama");
            comboBox1.Items.Add("Desktop Programlama");
            comboBox1.Items.Add("Oyun Programlama");
        }

        void Doldur2()
        {
            string[] iller = { "İstanbul", "Ankara", "İzmir", "Bursa" };
            comboBox2.Items.AddRange(iller);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            rdbEvet.Checked = true;
            Doldur();

            Doldur2();
        }

        private void rdbEvet_CheckedChanged(object sender, EventArgs e)
        {
        }

       void KontrolEt()
        {

            if (rdbEvet.Checked)
            {
                lblSayi.Text = "Demek evet diyorsun buna çok sevindim";
            }
            else
            {
                lblSayi.Text = "Aaa çok üzüldüm";
            }
        }
        private void rdbEvet_Click(object sender, EventArgs e)
        {
            if (rdbEvet.Checked)
            {
                lblSayi.Text = "Demek evet diyorsun buna çok sevindim";
            }
            else
            {
                lblSayi.Text = "Aaa çok üzüldüm";
            }
        }

        private void rdbHayır_Click(object sender, EventArgs e)
        {
            KontrolEt();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}
