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
    public partial class Form5 : Form
    {
        Random rnd = new Random();
        int rSayi = 0;
        
        public Form5()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rSayi = rnd.Next(1, 100);
            lblSayi.Text = rSayi.ToString();
        }
        void Secim()
        {


        }


        private void lblSayi_Click(object sender, EventArgs e)
        {
            

            if (timer1.Enabled==true)
            {
                
                timer1.Stop();
                if (rSayi % 2 == 0)
                {
                    MessageBox.Show("Kazandınız");
                }
                else
                {
                    MessageBox.Show("Kaybettiniz");

                }
            }
            else
            {
                timer1.Start();
            }
            

            }


        }
    }

