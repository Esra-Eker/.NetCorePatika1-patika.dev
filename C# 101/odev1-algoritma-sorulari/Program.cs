using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev1_algoritma_sorulari
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("********** 1.sorunun çözümü **********");
            Soru1();
            Console.WriteLine("********** 2.sorunun çözümü **********");
            Soru2();
            Console.WriteLine("********** 3.sorunun çözümü **********");
            Soru3();
            Console.WriteLine("********** 4.sorunun çözümü **********");
            Soru4();

        }

        public static void Soru1()
        {
            Console.Write("Pozitif sayı girin: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı girin: ", i + 1);
                dizi[i] = int.Parse(Console.ReadLine());

            }
            Console.Write("Girdiğiniz çift sayılar: ");
            for (int i = 0; i < dizi.Count(); i++)
            {
                if (dizi[i] % 2 == 0)
                    Console.Write(dizi[i] + "  ");
            }

            Console.ReadLine();
        }
        public static void Soru2()
        {
            Console.WriteLine("Pozitif 2 sayı girin: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[n];

            for(int i=0; i<n; i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz: ", i+1);
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("m e eşit ya da tam bölünen sayılar: ");
            for(int i=0; i<dizi.Length; i++)
            {
                if(dizi[i]==m || (dizi[i]%m==0))
                {
                    Console.WriteLine(dizi[i]);
                }
            }

            Console.ReadLine();
        }
        public static void Soru3()
        {
            Console.Write("Pozitif bir sayı girin: ");
            int n = Convert.ToInt32(Console.ReadLine());

            string[] dizi = new string[n];
            Console.WriteLine("n adet kelime girin: ");
            for(int i=0; i<n; i++)
            {
                dizi[i] = Console.ReadLine();
            }
            for(int i=dizi.Length-1; 0<i; i--)
            {
                Console.Write(dizi[i] + " ");
            }
            Console.ReadLine();
        }
        public static void Soru4()
        {
            Console.Write("Bir cümle yazın: ");
            string cumle = Console.ReadLine();

            string[] kelimeler = cumle.Split(' ');
            int kelimeSayisi = kelimeler.Length;
            Console.WriteLine("Cümledeki toplam kelime sayısı: " + kelimeSayisi);           

            int harfSayisi = 0;
            for(int i=0; i<kelimeler.Length; i++)
            {
                char[] harfDizi = kelimeler[i].ToCharArray();
                harfSayisi += harfDizi.Length;
            }
            Console.WriteLine("Cümledeki toplam harf sayısı: " + harfSayisi);
            Console.ReadLine();
            
                
        }
    }
}
