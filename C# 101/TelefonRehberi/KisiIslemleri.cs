using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    class KisiIslemleri
    {
        public List<Kisi> kisiListesi = new List<Kisi>(); //Kişi bilgilerini yönetmek için ihtiyacım var.
        public void YeniKisiEkle()
        {
            Console.WriteLine("İsim girin: ");
            string isim = Console.ReadLine();
            Console.WriteLine("Soyisim girin: ");
            string soyisim = Console.ReadLine();
            Console.WriteLine("Numara girin: ");
            string no = Console.ReadLine();

            kisiListesi.Add(new Kisi(isim, soyisim, no));
            Console.WriteLine("Kişi rehbere eklendi");
        }
        public void NumarayiSil()
        {
            Console.WriteLine("Numarasını silmek istediğiniz kişinin adını veya soyadını girin: ");
            string silmekicinara = Console.ReadLine();
            bool kontrol = false;
            

            foreach (Kisi item in kisiListesi)
            {
                if (silmekicinara == item.Isim || silmekicinara == item.Soyisim)
                {
                    Console.WriteLine("{0} {1} kişisi rehberden silinmek üzere, onaylıyor musunuz? (e/h)", item.Isim, item.Soyisim);
                    char cevap = Convert.ToChar(Console.ReadLine());
                    if (cevap == 'e')
                    {
                        kisiListesi.Remove(item); //Koleksiyon değiştirildi hatası veriyor!
                        Console.WriteLine("Kişi silindi!");                        
                        kontrol = true;
                        break;
                    }
                    else if (cevap == 'h')
                    {
                        Console.WriteLine("Kişi silinmedi!");
                        kontrol = true;
                    }
                }
            }
            if (kontrol==false)
            {
                Console.WriteLine("Kişi bulunamadı. Lütfen bir seçim yapın:");
                Console.WriteLine("Silmeyi sonlandırmak için: (1)");
                Console.WriteLine("Yeniden denemek için: (2)");
                int secim = Convert.ToInt32(Console.ReadLine());
                if(secim == 2)
                {
                    NumarayiSil();
                }
            }
            
        }
        public void NumaraGuncelle()
        {
            Console.WriteLine("Numarasını güncellemek istediğinz kişinin adını veya soyadını girin: ");
            string guncellemekicinara = Console.ReadLine();
            bool kontrol2 = false;

            foreach (var item in kisiListesi)
            {
                if (guncellemekicinara == item.Isim || guncellemekicinara == item.Soyisim)
                {
                    Console.WriteLine("{0} {1} kişisinin numarasını güncellemek için yeni bir numara girin: ", item.Isim, item.Soyisim);
                    string guncelno = Console.ReadLine();
                    item.No = guncelno; //Eski No yerine yeni Noyu yazacak.
                    Console.WriteLine("Güncelleme Tamamlandı!");
                    kontrol2 = true;
                    break;
                }
            }
            if(kontrol2==false)
            {
                Console.WriteLine("Kişi bulunamadı. Lütfen bir seçim yapın:");
                Console.WriteLine("Numara güncellemeyi sonlandırmak için: (1)");
                Console.WriteLine("Yeniden denemek için: (2)");
                int secim2 = Convert.ToInt32(Console.ReadLine());
                if (secim2 == 2)
                {
                    NumaraGuncelle();
                }
            }
        }
        public void RehberListele()
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("*************************");
            foreach (Kisi item in kisiListesi)
            {
                Console.WriteLine("İsim: {0}", item.Isim);
                Console.WriteLine("Soyisim: {0}", item.Soyisim);
                Console.WriteLine("Numara: {0}", item.No);
                Console.WriteLine("-");
            }
        }
        public void RehberdeAra()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçin.");
            Console.WriteLine("**************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Numaraya göre arama yapmak için: (2)");
            int secim3 = Convert.ToInt32(Console.ReadLine()); //aynı isimli değişkenleri 1 2 3 diye numaralandırmaya gerek yoktu ama ben karışmasın istedim.
            bool kontrol3 = false;

            if (secim3 == 1)
            {
                Console.WriteLine("Aramak istediğiniz ismi veya soyismi girin");
                string aranankisi = Console.ReadLine();            

                foreach (Kisi item in kisiListesi)
                {
                    if(aranankisi == item.Isim || aranankisi == item.Soyisim)
                    {
                        Console.WriteLine("Arama Sonuçlarınız:");
                        Console.WriteLine("************************");
                        Console.WriteLine("İsim: {0}", item.Isim);
                        Console.WriteLine("Soyisim: {0}", item.Soyisim);
                        Console.WriteLine("Numara: {0}", item.No);
                        kontrol3 = true;
                    }
                }
                if(kontrol3==false)
                {
                    Console.WriteLine("Aradığınız isim veya soyisimle uygun kişi rehberde bulunmadı. Yeniden aramak için 0 a basın:");
                    int secim5 = Convert.ToInt32(Console.ReadLine());
                    if (secim5 == 0)
                    {
                        RehberdeAra();
                    }                
                }
            }
            if(secim3 == 2)
            {
                Console.WriteLine("Aramak istediğiniz numarayı girin");
                string arananno = Console.ReadLine();
                foreach (Kisi item in kisiListesi)
                {
                    if(arananno == item.No)
                    {
                        Console.WriteLine("Arama Sonuçlarınız:");
                        Console.WriteLine("************************");
                        Console.WriteLine("İsim: {0}", item.Isim);
                        Console.WriteLine("Soyisim: {0}", item.Soyisim);
                        Console.WriteLine("Numara: {0}", item.No);
                        kontrol3 = true;
                    }
                }
                if(kontrol3 == false)
                {
                    Console.WriteLine("Aradığınız numarayla uygun kişi rehberde bulunmadı. Yeniden aramak için 0 a basın:");
                    int secim5 = Convert.ToInt32(Console.ReadLine());
                    if (secim5 == 0)
                    {
                        RehberdeAra();
                    }
                }

            }
        }
    }
}
