using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /* Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız. */
            
            Console.Write("Cümle girin: ");
            string cumle = Console.ReadLine();
            char[] sesliler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            List<char> harfler = new List<char>();

            for(int i=0; i<cumle.Length; i++)
            {
                if (sesliler.Contains(cumle[i]))  // cumle[i] harfi sesliler dizisinin içinde mi?
                {
                    harfler.Add(cumle[i]);
                }
            }


            //2.yol
       /*   foreach (var a in cumle)
            {
                foreach (var b in sesliler)
                {
                    if (a == b)
                        harfler.Add(a);
                }
            }  */
           

            Console.WriteLine("Girilen cümledeki sesli harfler: ");
            foreach (var item in harfler)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
    }
}
