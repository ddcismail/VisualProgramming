using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayilariBicimlendirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi;
            sayi = 15000000;
            MessageBox.Show(sayi.ToString("C"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi;
            sayi = 15000000;
            MessageBox.Show(sayi.ToString("N"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayi;
            sayi = 15000000;
            MessageBox.Show(sayi.ToString("E"));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sayi;
            sayi = 23.451784738;
            MessageBox.Show(sayi.ToString("F2"));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double sayi;
            sayi = 0.23;
            MessageBox.Show(sayi.ToString("P"));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = 236;
            MessageBox.Show(sayi.ToString("X"));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = 236;
            MessageBox.Show(sayi.ToString("X4"));
        }
    }
}
