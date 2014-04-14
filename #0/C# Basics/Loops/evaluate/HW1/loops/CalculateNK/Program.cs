using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateNK
{
    class Program
    {
        static void Main()
        {                                                                  
            int x = int.Parse(Console.ReadLine());                      
            int l = int.Parse(Console.ReadLine());
            int n = Math.Max(l, x);
            int k = Math.Min(l, x);
            int faktorielF = 1;
            int faktorielS = 1;
            for (int i =1;i<=n;i++)
            {
                faktorielF *= i;
                if (i <= k)
                {
                    faktorielS *= i;
                }
            }           
            Console.WriteLine(faktorielF/faktorielS);
        }
    }
}
