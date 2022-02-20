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
            for(int i=0; i<20; i++)
            {
                int sayi = Convert.ToInt32(Console.ReadLine());
                for (int j=1; j<=sayi; j++)
                {
                    if(sayi%2 == 0)
                    {
                        break;
                    }
                }
            }
        }
    }
}
