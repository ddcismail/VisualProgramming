using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa118_MDI_Formlar03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int yeni_form_sayisi = 0;

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yeni_form_sayisi++;
            Form2 cocuk_form = new Form2();
            cocuk_form.IsMdiContainer = IsMdiContainer;
            cocuk_form.Text = "Yeni Form" + yeni_form_sayisi.ToString();
            cocuk_form.Show();

        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

        }
    }
}
