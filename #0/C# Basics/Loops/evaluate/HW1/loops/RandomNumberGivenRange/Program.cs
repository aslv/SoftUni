using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGivenRange
{
    class Program 
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int max = Math.Max(a, b);
            int min = Math.Min(a, b);
            Random n = new Random();
            for (int i = 1; i <numbers; i++)
            {
                int resul = n.Next(min, max);
                Console.WriteLine(resul);
            }
        }
    }
}
