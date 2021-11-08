using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa49_ayniIsimliProsedurler2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int islem(int a, int b, int c)
        {
            return a + b + c;
        }
        int islem(int x, int y, int z, int t, int s)
        {
            return x + y + z + t + s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sonuc1, sonuc2;
            int sayi1 = 1, sayi2 = 2, sayi3 = 3, sayi4 = 4, sayi5 = 5;
            sonuc1 = islem(sayi1, sayi2, sayi3);
            sonuc2 = islem(sayi1, sayi2, sayi3, sayi4, sayi5);
            MessageBox.Show(sonuc1.ToString());
            MessageBox.Show(sonuc2.ToString());

        }
    }
}
