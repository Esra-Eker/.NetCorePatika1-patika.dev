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

            Console.WriteLine("Girdiğiniz sayı kadar pozitif sayı girin: ");

            for (int i=1;i<=n;i++)
            {
                int k = Convert.ToInt32(Console.ReadLine());
                
                if(k%2==0)
                    Console.WriteLine(i);
            }
            
            Console.ReadLine();
            


        }
    }
}
