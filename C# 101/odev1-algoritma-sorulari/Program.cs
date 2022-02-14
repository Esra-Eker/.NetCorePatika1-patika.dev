using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev1_algoritma_sorulari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pozitif sayı girin: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[n];

            for (int i=0 ; i<n ; i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı girin: ", i+1);
                dizi[i] = int.Parse(Console.ReadLine());
                  
            }
            Console.Write("Girdiğiniz çift sayılar: ");
            for(int i=0; i<dizi.Length ; i++)
            {
                if (dizi[i] % 2 == 0)
                    Console.Write(dizi[i] + "  " );
            }
            
            Console.ReadLine();
            


        }
    }
}
