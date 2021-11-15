using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa65_MessageBox.Show_M_B_D_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkamak İstediğinizden Emin Misiniz?", "ONAY", MessageBoxButtons.YesNoCancel);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkamak İstediğinizden Emin Misiniz?", "ONAY", MessageBoxButtons.AbortRetryIgnore);

        }
    }
}
