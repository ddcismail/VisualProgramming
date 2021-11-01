using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa46_FonksiyonVeAltProgram2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void sirala(int[] dizi)
        {
            int aradeger = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                for (int j = 0; j < dizi.GetUpperBound(0); j++)
                {
                    if (dizi[i] < dizi[j])
                    {
                        aradeger = dizi[j];
                        dizi[j] = dizi[i];
                        dizi[i] = aradeger;
                    }
                }

            }

            foreach (int eleman in dizi)
            {
                listBox1.Items.Add(eleman);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] dizi = new int[5] { 54, 11, 87, 9, 3 };
            sirala(dizi);

        }
    }
}
