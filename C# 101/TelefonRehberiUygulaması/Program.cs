using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberiUygulaması
{
    class Program
    {
        static Methodlar eris = new Methodlar();
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("********************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncellemek");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            int n = Convert.ToInt32(Console.ReadLine());


            /* string[] isimler = new string[] { "Deniz", "Tekin", "Tugce" };
             string[] soyadlar = new string[] { "Kara", "Akbay", "Bolat" };
             string[] nolar = new string[] { "457", "374", "573" };*/

            

            switch (n)
            {
                case 1:
                    {
                        Console.WriteLine("Yeni kişi oluştur");
                        Console.Write("Lütfen isim giriniz: ");
                        eris.YeniNumaraKaydet(Console.ReadLine());
                        
                        break;
                    }
                case 2:
                    {
                        break;
                    }
            
            }

            Console.ReadLine();
        }
    }
}
