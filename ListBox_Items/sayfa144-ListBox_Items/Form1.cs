using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa144_ListBox_Items
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {     
            listBox1.Items.Add("Bursa");
            listBox1.Items.Add("Denizli");
            listBox1.Items.Add("Düzce");
            listBox1.Items.Add("Ankara");
            listBox1.Items.Add("İstanbul");



        }
    }
}
