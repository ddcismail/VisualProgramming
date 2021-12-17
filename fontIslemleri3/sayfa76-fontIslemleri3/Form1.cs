using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa76_fontIslemleri3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FontFamily[] fontlar = FontFamily.Families;
            for (int i = 0; i < fontlar.Length; i++)
            {
                listBox_fontlar.Items.Add(fontlar[i].Name);
            }

        }

        private void listBox_fontlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txt_yazi.Font = new Font(listBox_fontlar.SelectedItem.ToString(), 16, FontStyle.Regular);
            }
            catch
            {
                MessageBox.Show("Bu font görüntelenemiyor.");
            }

        }
    }
}
