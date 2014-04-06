using System;
using System.Numerics;
using CalculateExpression2;

namespace CalculateCombination
{
    class Combination
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
            BigInteger result = CalculateFactorial.FactorialDivision(n, k) / CalculateFactorial.Factorial(n - k);
            Console.WriteLine("n!/(k!*(n-k)!) = {0}", result);
        }
    }
}
