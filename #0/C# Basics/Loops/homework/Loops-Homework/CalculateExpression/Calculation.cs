using System;
using System.Numerics;
// using CalculateExpression.Numerics;

namespace CalculateExpression
{
    class Calculation
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            // S = 1 + 1!/x + 2!/x2 + … + n!/xn
            double sum = 1;
            BigInteger factorial = 1, prodX = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                prodX *= x;
                sum += (double)factorial / (double)prodX;
                // Console.WriteLine((double)factorial / (double)prodX);
            }
            Console.WriteLine("{0:f5}", sum);
        }
    }
}
