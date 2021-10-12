using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String
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
            ifade = textBox1.Text;
            textBox2.Text = ifade.ToLower();
            // ToLower yöntemi ile string değer içerisinde bulunan tüm büyük harfler küçük harfe dönüştürülür.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ifade = "";
            ifade = textBox1.Text;
            textBox2.Text = ifade.ToUpper();
            //Yukarıdaki kodlar yerine sadece by kodda yazılabilir.
            //textBox2.Text = textBox1.Text.ToUpper();
        }
    }
}
