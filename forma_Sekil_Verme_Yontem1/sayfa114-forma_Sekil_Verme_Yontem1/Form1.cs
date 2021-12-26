using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa114_forma_Sekil_Verme_Yontem1
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
        Point tiklanan_nokta;

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

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            tiklanan_nokta = new Point(e.X, e.Y);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
