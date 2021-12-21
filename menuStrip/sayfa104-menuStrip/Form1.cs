using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa104_menuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int say, y = 30;

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button komut_dugmesi = new Button();
            komut_dugmesi.Top = y;
            komut_dugmesi.Left = 0;
            komut_dugmesi.Width = 150;
            say++;
            komut_dugmesi.Text = "Yeni Komut Düğmesi " + say.ToString();
            y += komut_dugmesi.Height + 5;

            komut_dugmesi.Click += new EventHandler(tıkla);

            this.Controls.Add(komut_dugmesi);

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(this.ActiveControl);

        }

        private void kontrolToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ekleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void tıkla(object sender, System.EventArgs e)
        {
            MessageBox.Show((sender as Button).Text + " tıklandı");
        }
    }
}
