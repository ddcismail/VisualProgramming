using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa44_while_sonsuzDongu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool tiklandimi;
        private void button2_Click(object sender, EventArgs e)
        {
            tiklandimi = false;
            int i = 0;
            int sayi_durum = 0;
            while (i < 10)
            {
                sayi_durum++;
                label1.Text = sayi_durum.ToString();
                Application.DoEvents();
                if (tiklandimi == true)
                {
                    break;
                }
            }
            MessageBox.Show(sayi_durum.ToString() + ". sayıda sonsuz döngüden çıkılmıştır.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tiklandimi = true;
        }
    
    }
}
