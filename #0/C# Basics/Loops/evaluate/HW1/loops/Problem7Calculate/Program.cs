using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7Calculate
{
    class Program
    {
        static void Main(string[] args)
        
        {
           
            int l = int.Parse(Console.ReadLine());                       
            int x = int.Parse(Console.ReadLine());
            int k = Math.Min(l, x);
            int n = Math.Max(l, x);
            int faktorielN = 1;
            int faktorielK = 1;
            int faktorielNK=1;
            int NK=n-k;
            for (int i = 1; i <= n; i++)
            {
                faktorielN *= i;
                if (i <= k)
                {
                    faktorielK *= i;
                }
            }
            for (int i = 1; i <= NK;i++ )
            {
                faktorielNK *= i;
            }
                Console.WriteLine(faktorielN /( faktorielK * faktorielNK));
        }
    }
}
