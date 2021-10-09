using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OzelFormat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long telNo;
            telNo = Convert.ToInt64(textBox1.Text);
            textBox2.Text = telNo.ToString("+## (###) ### ## ##");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
