using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa124_readOnly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_sifre.PasswordChar = '*';
            txt_adiniz.ReadOnly = true;
            txt_soyadiniz.ReadOnly = true;

        }

        private void btn_tamam_Click(object sender, EventArgs e)
        {
            if (txt_sifre.Text == "1357")
            {
                txt_adiniz.ReadOnly = false;
                txt_soyadiniz.ReadOnly = false;
            }
            else
            {
                txt_adiniz.ReadOnly = true;
                txt_soyadiniz.ReadOnly = true;
            }

        }
    }
}
