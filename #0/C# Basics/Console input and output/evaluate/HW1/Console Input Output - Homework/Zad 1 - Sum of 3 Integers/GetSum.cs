using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_1___Sum_of_3_Integers
{
    class GetSum
    {
        static void Main(string[] args)
        {
            double a, b, c;
            do
            {
                Console.Write("a = ");
                a = double.Parse(Console.ReadLine());
                Console.Write("b = ");
                b = double.Parse(Console.ReadLine());
                Console.Write("c = ");
                c = double.Parse(Console.ReadLine());
                double sum = a + b + c;
                Console.WriteLine("Sum: {0}", sum);
            }
            while(true);
        }
    }
}
