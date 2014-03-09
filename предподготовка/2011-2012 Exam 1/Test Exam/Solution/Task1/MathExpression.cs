using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1
{
    class MathExpression
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());

            double result = n * n + 1 / (m * p) + 1337;
            result /= n - 128.523123123 * p;
            result += Math.Sin((int)m % 180);
            Console.WriteLine("{0:F6}", result);
        }
    }
}
