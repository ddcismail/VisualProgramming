using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa79_koordinat_boyut4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sx = 5, sy = 5;

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Text = "";
            timer1.Interval = 100;
            timer1.Enabled = true;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (radioButton1.Top <= 0 || radioButton1.Bottom >= this.ClientSize.Height)
            {
                sy = -sy;
            }

            if (radioButton1.Left <= 0 || radioButton1.Right >= this.ClientSize.Width)
            {
                sx = -sx;
            }

            radioButton1.Left += sx;
            radioButton1.Top += sy;

        }
    }
}
