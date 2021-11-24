using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa66_MessageBox.Show_M__B__D__S__V_D_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkamak İstediğinizden Emin Misiniz?", "ONAY", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);//MessageBoxDefaultButton ile seçili button üzerinde vurgulama yapılır.

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dosyayı Silmek İstiyor Musunuz?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
        }
    }
}
