using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayaf178_DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker_dogum_tarihi.Format = DateTimePickerFormat.Short;
            dateTimePicker_kayit_tarihi.Format = DateTimePickerFormat.Short;
            dateTimePicker_mezuniyet_tarihi.Format = DateTimePickerFormat.Short;

            dateTimePicker_dogum_tarihi.MaxDate = DateTime.Now;
            dateTimePicker_kayit_tarihi.MaxDate = DateTime.Now;

            dateTimePicker_mezuniyet_tarihi.ShowCheckBox = true;

            listBox1.Font = new Font("Courier New", 10, FontStyle.Regular);
        }
        Boolean mezun_oldu;

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            string ogrenci_adsoyad, ogrenci_babaadi, ogrenci_dogumyeri;
            DateTime dogum_tarihi, kayit_tarihi, mezuniyet_tarihi;

            ogrenci_adsoyad = textBox1.Text;
            ogrenci_babaadi = textBox2.Text;
            ogrenci_dogumyeri = textBox3.Text;

            dogum_tarihi = dateTimePicker_dogum_tarihi.Value;
            kayit_tarihi = dateTimePicker_kayit_tarihi.Value;
            mezuniyet_tarihi = dateTimePicker_mezuniyet_tarihi.Value;

            if (dateTimePicker_mezuniyet_tarihi.Checked)
            {
                mezun_oldu = true;
            }
            else
            {
                mezun_oldu = false;
            }

            if (dogum_tarihi >= kayit_tarihi)
            {
                MessageBox.Show("Doğum Tarihi Veya Kayit Tarihi Yanlış Girişilmiş");
                return;
            }

            if (mezun_oldu)
            {
                if (kayit_tarihi > mezuniyet_tarihi)
                {
                    MessageBox.Show("Kayit Tarihi Veya Mezuniyet Tarihi Yanlış Girişilmiş");
                    return;
                }
            }

            listBox1.Items.Add(ogrenci_adsoyad +
                ogrenci_babaadi.PadLeft(10) +
                ogrenci_dogumyeri.PadLeft(10)+
                dogum_tarihi.ToShortDateString().PadLeft(15)+
                kayit_tarihi.ToShortDateString().PadLeft(15) +
                mezuniyet_tarihi.ToShortDateString().PadLeft(15) );
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
