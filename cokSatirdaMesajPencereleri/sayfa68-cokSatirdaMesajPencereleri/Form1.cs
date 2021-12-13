using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa68_cokSatirdaMesajPencereleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult a;
            a = MessageBox.Show("İşlemin Çalışması Çok Uzun Sürecektir. \r\n" +
               "Bunun sonucunda aşağıdaki sorunlarla karşılaşanilrisiniz. \r\n " +
               "1-Bilgisayarınız kilitlenebiir.  \r\n" +
               "2-İşlem bitene kadar bekleyebilirsiniz.  \r\n" +
               "3-Program kendini kapatabilir.\r\n" +
               "Yinede Devam Etmek İster Misiniz ?", "ONAY",
               MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (a == DialogResult.No)
            {
                this.Close();
            }

        }
    }
}
