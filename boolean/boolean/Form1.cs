using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boolean
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean bedeni_durum;
            bedeni_durum = checkBox1.Checked;

            if (bedeni_durum == true)
            {
                MessageBox.Show("Personel Evlidir");
            }
            else
            {
                MessageBox.Show("Personel Bekardır");
            }
        }
    }
}
