using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa79_koordinat_boyut2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Left = button1.Left;
            button2.Top = button1.Top + button1.Height + 20;
            button2.Width = button1.Width;
            button2.Height = button1.Height;

            button2.SetBounds(button1.Left, button1.Top + button1.Height + 20, button1.Width, button1.Height);

            button2.Location = new Point(button1.Left, button1.Top + button1.Height + 20);
            button2.Size = new Size(button1.Width, button1.Height);

        }
    }
}
