using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_Ifadelerin_Karsılastırilmasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ifade = "";
            int sonuc;
            ifade = textBox1.Text;

            //String.Compare(string_ifade1 ,string_ifade2)
            sonuc = string.Compare("Evet", ifade);

            if (sonuc == 0)
            {
                MessageBox.Show("Burs kaydı yapamazsınız");
            }
            else
            {
                MessageBox.Show("Burs işlemleri için devam ediniz");
            }

        }
    }
}
