using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa151_Uygulama1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            listBox_adisoyadi.Items.Add(txt_adisoyadi.Text);
            listBox_bolum.Items.Add(txt_bolum.Text);
            listBox_babaAdi.Items.Add(txt_babaadi.Text);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.IO.TextWriter bilgiyaz = System.IO.File.CreateText("C:\\bilgi_kayit.dat");

            for (int i = 0; i < listBox_adisoyadi.Items.Count; i++)
            {
                bilgiyaz.WriteLine(listBox_adisoyadi.Items[i]);
                bilgiyaz.WriteLine(listBox_bolum.Items[i]);
                bilgiyaz.WriteLine(listBox_babaAdi.Items[i]); ;
            }

            MessageBox.Show("Bilgiler C klasörünün içinde bilgi_kayit adında dosyaya kayıt edilmiştir");
            bilgiyaz.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                System.IO.TextReader bilgioku = System.IO.File.OpenText("C:\\bilgi_kayit.dat");
                string satir;
                while ((satir = bilgioku.ReadLine()) != null)
                {
                    listBox_adisoyadi.Items.Add(satir);

                    satir = bilgioku.ReadLine();
                    listBox_bolum.Items.Add(satir);

                    satir = bilgioku.ReadLine();
                    listBox_babaAdi.Items.Add(satir);

                    bilgioku.Close();
                }
            }
            catch
            {
            }

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int indis;
            indis = listBox_adisoyadi.SelectedIndex;
            if (indis < 0)
            {
                MessageBox.Show("Silinecek Elemanı Seçiniz");
            }
            else
            {
                listBox_adisoyadi.Items.RemoveAt(indis);
                listBox_bolum.Items.RemoveAt(indis);
                listBox_babaAdi.Items.RemoveAt(indis);
            }

        }

        private void eleman_tiklanirsa(object sender, EventArgs e)
        {
            
                int indis;
                indis = (sender as ListBox).SelectedIndex;

                listBox_adisoyadi.SelectedIndex = indis;
                listBox_bolum.SelectedIndex = indis;
                listBox_babaAdi.SelectedIndex = indis;

                int top_indis;
                top_indis = (sender as ListBox).TopIndex;
                listBox_adisoyadi.TopIndex = top_indis;
                listBox_bolum.TopIndex = top_indis;
                listBox_babaAdi.TopIndex = top_indis;
            

        }
    }
}
