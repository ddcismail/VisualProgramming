using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomSayi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele_sayi = new Random();
            int üretililen_sayi;
            üretililen_sayi = rastgele_sayi.Next();
            textBox1.Text += üretililen_sayi.ToString()+Environment.NewLine;
        }
    }
}
