using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa123_textBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_buyuk_Click(object sender, EventArgs e)
        {
            textBox1.CharacterCasing = CharacterCasing.Upper;

        }

        private void btn_kucuk_Click(object sender, EventArgs e)
        {
            textBox1.CharacterCasing = CharacterCasing.Lower;

        }

        private void btn_normal_Click(object sender, EventArgs e)
        {
            textBox1.CharacterCasing = CharacterCasing.Normal;

        }
    }
}
