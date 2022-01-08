using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa148_Items_Contains
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
            string ekle;
            ekle = textBox1.Text;

            if (listBox1.Items.Contains(ekle) == true)
            {
                MessageBox.Show("Bu kelime zaten listede var");
            }
            else if (listBox1.Items.Contains(ekle) == false)
            {
                MessageBox.Show(ekle + " kelimesi listeye eklenmiştir.");
                listBox1.Items.Add(ekle);
            }

        }
    }
}
