using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
             * her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. 
             * (Array sınıfını kullanarak yazınız.)*/

            ArrayList sayiListesi = new ArrayList();
            ArrayList eb3 = new ArrayList();
            ArrayList ek3 = new ArrayList();
            double eb3T = 0;
            double ek3T = 0;
            
            Console.WriteLine("Lütfen 20 tane sayı girin. " + " ");
            for(int i=0; i<20; i++)
            {
                int sayi = Convert.ToInt32(Console.ReadLine());
                sayiListesi.Add(sayi);
            }

            sayiListesi.Sort();

           // ArrayList eb3 = sayiListesi.GetRange(7, 3);   böyle yaparak sayiListesi nden 7den itibaren 3 sayıyı eb3 listesine atmış olurduk.
           // ArrayList ek3 = sayiListesi.GetRange(0,3);    böyle yaparak sayiListesi nden 0dan itibaren 3 sayıyı ek3 listesine atmış olurduk. forlara ve Add lere gerek kalmazdı.

            Console.WriteLine("Girilen sayıların sıralaması: ");
            foreach (var item in sayiListesi)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            
            for(int i=0; i<3; i++)
            {
                ek3.Add(sayiListesi[i]);
            }
            for(int i=19; 16<i; i--)
            {
                eb3.Add(sayiListesi[i]);
            }

            Console.WriteLine("En büyük 3 sayı: ");
            foreach (int item in eb3)
            {
                Console.Write(item + " ");
                eb3T += item;
            }
            Console.WriteLine("\nEn küçük 3 sayı: ");
            foreach (int item in ek3)
            {
                Console.Write(item + " ");
                ek3T += item;
            }
            Console.WriteLine();
            Console.WriteLine("En büyük 3 sayının ortalaması: " + eb3T / eb3.Count);
            Console.WriteLine("En küçük 3 sayının ortalaması: " + ek3T / ek3.Count);
            Console.WriteLine("Ortalama toplamları: " + ((eb3T / eb3.Count) + (ek3T / ek3.Count))) ;  


            Console.ReadLine();
        }
    }
}
