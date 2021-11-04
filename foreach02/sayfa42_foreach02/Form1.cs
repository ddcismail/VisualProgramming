using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa42_foreach02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int[] sayi_dizisi = new int[11];

            for (int i = 0; i <= 10; i++)
            {
                sayi_dizisi[i] = i;
            }

            foreach (int i in sayi_dizisi)
            {
                listBox1.Items.Add(sayi_dizisi[i]);
                toplam += Convert.ToInt16(i);
            }
            listBox1.Items.Add("+ ");
            listBox1.Items.Add("----------- ");
            listBox1.Items.Add(" " + toplam.ToString());
        }
    }
}
