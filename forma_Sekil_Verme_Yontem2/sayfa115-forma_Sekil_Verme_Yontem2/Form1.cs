using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa115_forma_Sekil_Verme_Yontem2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Point tiklanan_nokta;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath grafik_sekil;
            grafik_sekil = new System.Drawing.Drawing2D.GraphicsPath();

            grafik_sekil.AddRectangle(new Rectangle(0, 0, this.ClientSize.Width, 90));
            grafik_sekil.AddString("Bizim Formumuz", new FontFamily("Tahoma"), (int)FontStyle.Bold, (float)72, new PointF(0, 100), new StringFormat(StringFormat.GenericDefault));
            grafik_sekil.AddRectangle(new Rectangle(0, this.ClientSize.Height - 90, this.ClientSize.Width, 90));

            this.Region = new Region(grafik_sekil);

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            tiklanan_nokta = new Point(e.X, e.Y);

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point koordinatlar;
                koordinatlar = Control.MousePosition;
                koordinatlar.Offset(-tiklanan_nokta.X, -tiklanan_nokta.Y);
                this.Location = koordinatlar;
            }

        }
    }
}
