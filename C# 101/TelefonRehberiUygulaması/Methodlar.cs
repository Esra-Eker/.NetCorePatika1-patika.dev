using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberiUygulaması
{
    public class Methodlar 
    {
        string[] isimler = new string[] { "Deniz", "Tekin", "Tugce" };
        public void YeniNumaraKaydet(string isim)
        {
              isimler[3] = isim;
              Console.WriteLine("İsim Başarıyla Kaydedildi...");
            for (int i = 0; i <4; i++)
            {
                Console.WriteLine(isimler[i]);
            }
        }
    }
}
