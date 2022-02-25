using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberiUygulaması
{
    class Kisiler
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string No { get; set; }


        public Kisiler(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }

    }
}
