using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kayanYazi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 500; //yazının kayma hızı ayarlandı
            timer1.Enabled = true; //timer kontrolü çalıştırıldı.
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //texBox kontrolünde bulunan yazının ilk karakteri alınıp en sona ekleme işlemi yapılıyor.
            textBox1.Text = textBox1.Text.Substring(1) + textBox1.Text.Substring(0, 1);
        }
    }
}
