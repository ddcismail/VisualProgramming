using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexaDecimalSayi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long decimal_sayi;
            decimal_sayi = long.Parse(textBox1.Text);
            textBox2.Text = decimal_sayi.ToString("X8"); // 8 basamaga tamamlar.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            long hexadecimal_sayi;
            hexadecimal_sayi = long.Parse(textBox2.Text, System.Globalization.NumberStyles.HexNumber);
            textBox1.Text = hexadecimal_sayi.ToString();
        }
    }
}
