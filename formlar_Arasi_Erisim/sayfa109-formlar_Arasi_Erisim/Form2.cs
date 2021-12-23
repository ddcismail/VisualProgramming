using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa109_formlar_Arasi_Erisim
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int x;

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "x değişkeninin değeri= " + x.ToString();

        }
    }
}
