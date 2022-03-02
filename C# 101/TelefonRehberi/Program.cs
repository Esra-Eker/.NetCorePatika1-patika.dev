using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    class Program
    {
        static void Main(string[] args)
        {
            KisiIslemleri islem = new KisiIslemleri();

            Console.WriteLine("Telefon Rehberine Hoşgeldiniz :)");
            Console.WriteLine("***************************************");
            Console.WriteLine("(1)-Yeni Telefon Numarası Kaydet");
            Console.WriteLine("(2)-Telefon Numarası Sil");
            Console.WriteLine("(3)-Telefon Numarası Güncelle");
            Console.WriteLine("(4)-Rehber Listeleme");
            Console.WriteLine("(5)-Rehberde Arama");
            Console.WriteLine("(x)-Rehberden Çık");          

            // List<Kisi> kisiListesi = new List<Kisi>(); bunu hem burda hem KullanıcıIslemleri.cs de tanımlamam ne kadar yanlış bir hareket? 
            islem.kisiListesi.Add(new Kisi("Umut", "Tezcan", "427"));
            islem.kisiListesi.Add(new Kisi("Tugce", "Yılmaz", "319"));
            islem.kisiListesi.Add(new Kisi("Deniz", "Cetin", "658"));
            islem.kisiListesi.Add(new Kisi("Kerem", "Yayla", "354"));
            islem.kisiListesi.Add(new Kisi("Ela", "Kızıl", "885"));

            while(true)
            {
                Console.WriteLine("Lütfen yapmak istediğin işlemi seçin.");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        islem.YeniKisiEkle();
                        break;
                    case "2":
                        islem.NumarayiSil();
                        break;
                    case "3":
                        islem.NumaraGuncelle();
                        break;
                    case "4":
                        islem.RehberListele();
                        break;
                    case "5":
                        islem.RehberdeAra();
                        break;
                    case "x":
                        return;
                    default:
                        Console.WriteLine("Geçersiz işlem girdiniz!");
                        break;
                }
                
            } 


            Console.ReadLine();
        }
    }
}
