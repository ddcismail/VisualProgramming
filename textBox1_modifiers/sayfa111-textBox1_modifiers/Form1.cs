using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa111_textBox1_modifiers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 bizim_ikinci_formumuz = new Form2();
            bizim_ikinci_formumuz.x = 100;
            bizim_ikinci_formumuz.textBox1.Text = "X in degeri = 100";
            bizim_ikinci_formumuz.Show();

        }
    }
}
