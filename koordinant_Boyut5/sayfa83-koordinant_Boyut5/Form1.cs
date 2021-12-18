using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa83_koordinant_Boyut5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ifadeler = { "Yok", "Sağa", "Sola", "Üste", "Alta", "İçine" };
            comboBox1.Items.AddRange(ifadeler);
            comboBox2.Items.AddRange(ifadeler);
            comboBox3.Items.AddRange(ifadeler);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Yok")
            {
                groupBox1.Dock = DockStyle.None;
            }
            else if (comboBox1.Text == "Sağa")
            {
                groupBox1.Dock = DockStyle.Right;
            }
            else if (comboBox1.Text == "Sola")
            {
                groupBox1.Dock = DockStyle.Left;
            }
            else if (comboBox1.Text == "Üste")
            {
                groupBox1.Dock = DockStyle.Top;
            }
            else if (comboBox1.Text == "Alta")
            {
                groupBox1.Dock = DockStyle.Bottom;
            }
            else if (comboBox1.Text == "İçine")
            {
                groupBox1.Dock = DockStyle.Fill;
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Yok")
            {
                groupBox3.Dock = DockStyle.None;
            }
            else if (comboBox3.Text == "Sağa")
            {
                groupBox3.Dock = DockStyle.Right;
            }
            else if (comboBox3.Text == "Sola")
            {
                groupBox3.Dock = DockStyle.Left;
            }
            else if (comboBox3.Text == "Üste")
            {
                groupBox3.Dock = DockStyle.Top;
            }
            else if (comboBox3.Text == "Alta")
            {
                groupBox3.Dock = DockStyle.Bottom;
            }
            else if (comboBox3.Text == "İçine")
            {
                groupBox3.Dock = DockStyle.Fill;
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Yok")
            {
                groupBox2.Dock = DockStyle.None;
            }
            else if (comboBox2.Text == "Sağa")
            {
                groupBox2.Dock = DockStyle.Right;
            }
            else if (comboBox2.Text == "Sola")
            {
                groupBox2.Dock = DockStyle.Left;
            }
            else if (comboBox2.Text == "Üste")
            {
                groupBox2.Dock = DockStyle.Top;
            }
            else if (comboBox2.Text == "Alta")
            {
                groupBox2.Dock = DockStyle.Bottom;
            }
            else if (comboBox2.Text == "İçine")
            {
                groupBox2.Dock = DockStyle.Fill;
            }

        }
    }
}
