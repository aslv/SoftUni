using System;
using System.Numerics;

namespace CalculateExpression2
{
    public class CalculateFactorial
    {
        public static BigInteger FactorialDivision(int n, int k)
        {
            BigInteger result = 1;
            if (n < k)
            {
                throw new ArgumentOutOfRangeException("n must be greater or equal to k");
            }
            for (int i = k + 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        public static BigInteger Factorial(int n)
        {
            BigInteger result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }

    class CalcFact
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("n!/k! = {0}", CalculateFactorial.FactorialDivision(n, k));
        }
    }
}
