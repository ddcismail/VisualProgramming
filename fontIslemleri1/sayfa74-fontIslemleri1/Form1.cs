using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa74_fontIslemleri1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_kalin_Click(object sender, EventArgs e)
        {
            txt_yazi.Font = new Font(txt_yazi.Font, txt_yazi.Font.Style ^ FontStyle.Bold);

        }

        private void btn_egik_Click(object sender, EventArgs e)
        {
            txt_yazi.Font = new Font(txt_yazi.Font, txt_yazi.Font.Style ^ FontStyle.Italic);

        }

        private void btn_alticizik_Click(object sender, EventArgs e)
        {
            txt_yazi.Font = new Font(txt_yazi.Font, txt_yazi.Font.Style ^ FontStyle.Underline);

        }

        private void btn_ustucizik_Click(object sender, EventArgs e)
        {
            txt_yazi.Font = new Font(txt_yazi.Font, txt_yazi.Font.Style ^ FontStyle.Strikeout);

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            txt_yazi.Font = new Font(txt_yazi.Font.Name, (float)numericUpDown1.Value, txt_yazi.Font.Style);

        }
    }
}
