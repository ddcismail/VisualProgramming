using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa169_comboBox_renkler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] renkler_listesi = { "Kırmızı", "Yeşil", "Sarı", "Mavi", "Pembe", "Kahverengi" };
            comboBox1.Items.AddRange(renkler_listesi);
        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Color renkler = Color.Black;
            string eleman;
            eleman = comboBox1.Items[e.Index].ToString();

            if (eleman=="Kırmızı")
            {
                renkler = Color.Red;
            }
            else if (eleman == "Yeşil")
            {
                renkler = Color.Green;
            }
            else if (eleman == "Sarı")
            {
                renkler = Color.Yellow;
            }
            else if (eleman == "Mavi")
            {
                renkler = Color.Blue;
            }
            else if (eleman == "Pembe")
            {
                renkler = Color.Pink;
            }
            else if (eleman == "Kahverengi")
            {
                renkler = Color.Brown;
            }

            if (e.State==DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.Turquoise), e.Bounds.Left, e.Bounds.Top, e.Bounds.Width, e.Bounds.Height);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(renkler), e.Bounds.Left, e.Bounds.Top, e.Bounds.Width, e.Bounds.Height);
            }

            e.Graphics.DrawString(eleman,e.Font,new SolidBrush(Color.White),e.Bounds.Left,e.Bounds.Top);

            e.DrawFocusRectangle();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color renkler = Color.Black;
            string eleman;
            eleman = comboBox1.SelectedItem.ToString();

            if (eleman == "Kırmızı")
            {
                renkler = Color.Red;
            }
            else if (eleman == "Yeşil")
            {
                renkler = Color.Green;
            }
            else if (eleman == "Sarı")
            {
                renkler = Color.Yellow;
            }
            else if (eleman == "Mavi")
            {
                renkler = Color.Blue;
            }
            else if (eleman == "Pembe")
            {
                renkler = Color.Pink;
            }
            else if (eleman == "Kahverengi")
            {
                renkler = Color.Brown;
            }
            this.BackColor = renkler;
            comboBox1.BackColor = renkler;
            comboBox1.ForeColor = Color.White;
        }
    }
}
