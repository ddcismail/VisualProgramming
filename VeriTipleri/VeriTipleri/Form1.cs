using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriTipleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            float sonuc;
            sayi1 = 10;
            sayi2 = 3;
            sonuc = sayi1 / sayi2;
            MessageBox.Show("işlem sonucu=" + sonuc.ToString());
        }
    }
}
