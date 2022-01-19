using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa173_DomainUpDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] renkler = { "Kırmızı", "Sarı", "Yeşil", "Mavi", "Pembe", "Kahverengi", "Siyah" };
            domainUpDown1.Items.AddRange(renkler);
            domainUpDown1.Wrap = true;
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            if (domainUpDown1.SelectedIndex>=0)
            {
                if (domainUpDown1.SelectedItem.ToString() =="Kırmızı")
                {
                    panel1.BackColor = Color.Red;
                }
                if (domainUpDown1.SelectedItem.ToString() == "Sarı")
                {
                    panel1.BackColor = Color.Yellow;
                }
                if (domainUpDown1.SelectedItem.ToString() == "Yeşil")
                {
                    panel1.BackColor = Color.Green;
                }
                if (domainUpDown1.SelectedItem.ToString() == "Mavi")
                {
                    panel1.BackColor = Color.Blue;
                }
                if (domainUpDown1.SelectedItem.ToString() == "Pembe")
                {
                    panel1.BackColor = Color.Pink;
                }
                if (domainUpDown1.SelectedItem.ToString() == "Kahverengi")
                {
                    panel1.BackColor = Color.Brown;
                }
                if (domainUpDown1.SelectedItem.ToString() == "Siyah")
                {
                    panel1.BackColor = Color.Black;
                }
            }
        }
    }
}
