using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa74_fontIslemleri2
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

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            FontFamily[] fontlar = FontFamily.GetFamilies(e.Graphics);
            Font fnt = null;
            float x = 0, y = 0;
            string ifade;
            for (int i = 0; i < fontlar.Length; i++)
            {
                try
                {
                    fnt = new Font(fontlar[i].Name, 10, FontStyle.Regular);
                    ifade = fontlar[i].Name;
                }
                catch
                {
                    ifade = fontlar[i].Name + "bu font görüntülenemedi.";

                }
                e.Graphics.DrawString(ifade, fnt, Brushes.Black, x, y);
                y += fnt.Height;
                if (((i + 1) % 20) == 0)
                {
                    x = x + 200;
                    y = 0;
                }
            }

        }
    }
}
