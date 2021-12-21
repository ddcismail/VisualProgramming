using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa105_forma_Ait_Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int orijinal_x = 800;
        int orijinal_y = 600;

        private void Form1_Load(object sender, EventArgs e)
        {
            Rectangle cozunurluk = new Rectangle();
            cozunurluk = Screen.GetBounds(cozunurluk);
            float oran_x, oran_y;
            oran_x = (float)cozunurluk.Width / orijinal_x;
            oran_y = (float)cozunurluk.Height / orijinal_y;
            this.Left = 0;
            this.Top = 0;
            this.Scale(oran_x, oran_y);

        }
    }
}
