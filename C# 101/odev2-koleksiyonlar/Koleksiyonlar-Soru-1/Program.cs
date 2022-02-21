using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList asal = new ArrayList();
            ArrayList asaldegil = new ArrayList();
            
            int sayac = 0;
            int asalToplam = 0;
            int asaldegilToplam = 0;
        
            Console.WriteLine("Sayı girin: ");
            try
            {
                for (int i = 0; i < 20; i++)
                {
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    sayac = 0;
                    if (sayi > 0)
                    {
                        for (int j = 2; j < sayi; j++)
                        {
                            if (sayi % j == 0)
                            {
                                sayac++;
                            }
                        }
                        if (sayac != 0)
                        {
                            Console.WriteLine("Girilen sayı asal değil.");
                            asaldegil.Add(sayi);
                        }
                        else if (sayi == 1)
                        {
                            Console.WriteLine("Girilen sayı asal değil.");
                            asaldegil.Add(sayi);
                        }
                        else
                        {
                            Console.WriteLine("Girilen sayı asal.");
                            asal.Add(sayi);
                        }
                    }
                    else
                        Console.WriteLine("Lütfen pozitif bir sayı girin!");
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Lütfen pozitif bir tam sayı girin!");
            }
            asal.Sort();
            asal.Reverse();
            asaldegil.Sort();
            asaldegil.Reverse();

            foreach(int item in asal)
            {
                Console.Write(item + " ");
                asalToplam += item;
            }
            Console.WriteLine();
            foreach(int item in asaldegil)
            {
                Console.Write(item + " ");
                asaldegilToplam += item;
            }
            Console.WriteLine();
            Console.WriteLine("Toplam asal sayı: " + asal.Count);
            Console.WriteLine("Toplam asal olmayan sayı: " + asaldegil.Count);
            Console.WriteLine("Asal sayı dizisinin ortalaması: " + (double)asalToplam / asal.Count);
            Console.WriteLine("Asal değil dizisinin ortalaması: " + (double)asaldegilToplam / asaldegil.Count);
            Console.ReadLine();
        }
    }
}

/*  Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

Negatif ve numeric olmayan girişleri engelleyin.
Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.  */
