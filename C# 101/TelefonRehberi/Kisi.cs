using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    class Kisi
    {
        private string isim, soyisim, no;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public string No { get => no; set => no = value; }
        
        public Kisi(string isim, string soyisim, string no) //kişiye 3 değer atıyabilmemizi sağladı
        {
              this.isim = isim;
              this.soyisim = soyisim;
              this.no = no;
        }

    }
}
