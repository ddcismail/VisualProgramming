using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa174_TrackBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            double[] katsayilar = { 0.25, 0.5, 1, 2, 3, 4 };
            pictureBox1.Width = Convert.ToInt32(pictureBox1.Image.Width * katsayilar[trackBar1.Value]);
            pictureBox1.Height = Convert.ToInt32(pictureBox1.Image.Height * katsayilar[trackBar1.Value]);
        }
    }
}
