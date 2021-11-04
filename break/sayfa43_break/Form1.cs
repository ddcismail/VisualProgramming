using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa43_break
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] isimler = new string[5] { "İsmail", "Bugra", "Ahmet", "Mehmet", "Ayşe" };
            string aranan_isim = "İsmail";

            int i;
            for (i = 0; i < isimler.Length; i++)
            {
                if (aranan_isim == isimler[i])
                {
                    break;
                }
            }
            MessageBox.Show(isimler[i] + " isimli kişi dizide " + (i + 1) + ". sıradadır.");

        }
    }
}
