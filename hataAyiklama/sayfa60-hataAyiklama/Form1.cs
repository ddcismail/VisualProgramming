using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa60_hataAyiklama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal sayi1 = 5, sayi2 = 0;
            decimal sonuc;
            try
            {
                sonuc = sayi1 / sayi2;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Program bir hatayla karşılaştı. Hatnın sebebi " + "Aşağıda belirtilmiştirr. \r\n" + hata.Message);
            }

        }
    }
}
