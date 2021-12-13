using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vb = Microsoft.VisualBasic.Interaction;

namespace sayfa69_ınputBox2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            double ortalama;
            int[] dizi = new int[Convert.ToInt32(vb.InputBox("Eleman sayısı", "Giriş", "0", 100, 100))];

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = Convert.ToInt32(vb.InputBox(i + 1 + ". inci sayı", "Dizinin elemanlarını giriniz", "0", 100, 100));
                listBox1.Items.Add(dizi[i]);
                toplam += dizi[i];
            }
            ortalama = Convert.ToDouble(toplam) / dizi.Length;
            listBox1.Items.Add("Ortalama= " + ortalama);

        }
    }
}
