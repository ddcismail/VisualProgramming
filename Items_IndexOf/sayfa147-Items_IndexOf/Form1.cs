using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa147_Items_IndexOf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            listBox1.Items.AddRange(gunler);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string aranan;
            aranan = textBox1.Text;
            int yer;
            yer = listBox1.Items.IndexOf(aranan);

            if (yer < 0)
            {
                MessageBox.Show("Aradığınız kelime bulunamamıştır");
            }
            else
            {
                MessageBox.Show("Aradığınız kelime " + (yer + 1) + ".sıradadır");
            }

        }
    }
}
