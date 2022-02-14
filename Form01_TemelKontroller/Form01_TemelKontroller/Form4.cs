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
    public partial class Form4 : Form
    {
        int sure = 100;
        public Form4()
        {
            InitializeComponent();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {

            label1.Left = label1.Left + 10;


        }

        private void Form4_Load(object sender, EventArgs e)
        {
            tmr.Enabled = true;
            tmr.Start();
            lblSure.Text = sure.ToString();
            timer1.Enabled = true;
            timer1.Start();
            btnRestart.Visible = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure -= 1;
            lblSure.Text = sure.ToString();
            if (sure==0)
            {
                sure = 100;
                timer1.Stop();
                btnRestart.Visible =true;
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btnRestart.Visible = false;
            label1.Left = 0;
        }
    }
}
