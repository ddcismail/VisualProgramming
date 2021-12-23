using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa108_ısDisposed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 bizim_ikinci_formumuz;

        private void button1_Click(object sender, EventArgs e)
        {
            if ((bizim_ikinci_formumuz == null) || (bizim_ikinci_formumuz.IsDisposed))
            {
                bizim_ikinci_formumuz = new Form2();
                bizim_ikinci_formumuz.Show();
            }
            else
            {
                bizim_ikinci_formumuz.Activate();
            }

        }
    }
}
