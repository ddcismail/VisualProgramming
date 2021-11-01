using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa47_FobksiyonVeAltProgram3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int kucukbul(params int[] degerler)
        {
            int minibul = 1;
            if (degerler.Length > 0)
            {
                minibul = degerler[0];
            }
            for (int i = 0; i < degerler.Length; i++)
            {
                if (degerler[i] < minibul)
                {
                    minibul = degerler[1];
                }
            }
            return minibul;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int deger1, deger2;
            deger1 = kucukbul(10, 20, 5);
            deger2 = kucukbul(2, 22, 55, 72, 99, 5);
            MessageBox.Show(deger1.ToString());
            MessageBox.Show(deger2.ToString());

        }
    }
}
