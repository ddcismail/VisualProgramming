using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayilariYuvarlama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi;
            sayi = 15.3563784;
            MessageBox.Show("Sayının ilk hali= " + Math.Round(sayi, 0).ToString());
            MessageBox.Show("Sayının ikinci hali= " + Math.Round(sayi, 1).ToString());
            MessageBox.Show("Sayının üçüncü hali= " + Math.Round(sayi, 2).ToString());
        }
    }
}
