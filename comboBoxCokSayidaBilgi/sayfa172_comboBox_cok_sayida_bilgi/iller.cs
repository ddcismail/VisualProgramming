using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayfa172_comboBox_cok_sayida_bilgi
{
    class iller
    {
        public string adi;
        public string plaka;

        public iller(string ad, string plk)
        {
            adi = ad;
            plaka = plk;
        }
        public iller()
        {
            adi = "";
            plaka = "";
        }
        public override string ToString()
        {
            return plaka + " " + adi;
        }
    }
}
