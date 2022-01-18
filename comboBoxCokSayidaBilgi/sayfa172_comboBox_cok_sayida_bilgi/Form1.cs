using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa172_comboBox_cok_sayida_bilgi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            iller[] il = {new iller ("İzmit","41"),
            new iller ("Sakarya","54"),
            new iller ("İstanbul","34"),
            new iller ("Bursa","16"),
            new iller ("Muğla","48"),
            new iller ("İzmir","35"),
            new iller ("Balıkesir","10")};
            comboBox1.Items.AddRange(il);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex<0)
            {
                return;
            }
            label3.Text = ((iller) comboBox1.SelectedItem).adi;
            label5.Text = ((iller) comboBox1.SelectedItem).plaka;
        }
    }
}
