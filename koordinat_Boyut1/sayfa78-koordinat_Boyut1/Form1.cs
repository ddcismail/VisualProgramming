using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa78_koordinat_Boyut1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown_sol.Maximum = 500;
            numericUpDown_ust.Maximum = 500;
            numericUpDown_yukseklik.Maximum = 500;
            numericUpDown_genislik.Maximum = 500;

            numericUpDown_sol.Value = textBox1.Left;
            numericUpDown_ust.Value = textBox1.Top;
            numericUpDown_yukseklik.Value = textBox1.Width;
            numericUpDown_genislik.Value = textBox1.Height;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown_sol_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Left = (int)numericUpDown_sol.Value;
        }

        private void numericUpDown_genislik_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Width = (int)numericUpDown_genislik.Value;
        }

        private void numericUpDown_ust_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Top = (int)numericUpDown_ust.Value;
        }

        private void numericUpDown_yukseklik_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Height = (int)numericUpDown_yukseklik.Value;

        }
    }
}
