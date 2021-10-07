using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinirAsimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte x = 250;
            x += 6;
            MessageBox.Show(x.ToString(), "x 'in değeri"); //x=0 degeri verir.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte x = 250;
            x += 100;
            MessageBox.Show(x.ToString(), "x 'in değeri");//x=94 degeri verir.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = 250000;
            x = checked(x * 10000);
            MessageBox.Show(x.ToString(),"x'in degeri"); //Eğer bir proje yazmaya başladığınızda tip atamalarını yaparken projenin tamamlanıp kullanım aşamasında yanlış bir sayısal işlem sonucunda tip tanımlamasının alabileceği değer aşımıolduğunda kullanıcıya hata mesajının gösterimi yapılarak kullanıcının dikkati çekilebilir. Bunun için checked deyimi kullanılır.
        }
    }
}
