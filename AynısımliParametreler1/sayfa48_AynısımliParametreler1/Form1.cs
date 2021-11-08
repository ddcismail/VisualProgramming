using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa48_AynısımliParametreler1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        long islem(long x, long y)
        {
            return x * y;
        }
        int islem(int x, int y)
        {
            return x + y;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            long sonuc;
            int x = 2, y = 5;
            sonuc = islem((long)x, (long)y);
            MessageBox.Show(sonuc.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sonuc;
            int x = 5, y = 10;
            sonuc = islem((int)x, (int)y);
            MessageBox.Show(sonuc.ToString());

        }
    }
}
