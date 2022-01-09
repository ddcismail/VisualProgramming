using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa150_Items_CopyTo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] dizi1 = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            string[] dizi2 = { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };

            listBox1.Items.Add("Haftanın Günleri");
            listBox1.Items.Add("-----*****------");
            listBox1.Items.AddRange(dizi1);

            listBox2.Items.Add("Aylar");
            listBox2.Items.Add("--**--");
            listBox2.Items.AddRange(dizi2);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            object[] x = new object[listBox1.Items.Count + listBox2.Items.Count];
            listBox1.Items.CopyTo(x, 0);
            listBox2.Items.CopyTo(x, listBox1.Items.Count);

            listBox3.Items.Add("2 Listenin Birleşmiş Hali");
            listBox3.Items.Add("--------------------------------");
            listBox3.Items.AddRange(x);

        }
    }
}
