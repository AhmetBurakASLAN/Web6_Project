using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WithClassSQL_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SampleClass benimSınifim = new SampleClass();
            MessageBox.Show(benimSınifim.AdSoyad);
            int sonuc = benimSınifim.Topla(46, 300);
            MessageBox.Show($"sonuc ={sonuc}");
            

        }
    }
}
