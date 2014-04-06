using System;

namespace PrimeChecker
{
    class CheckWhetherPrime
    {
        static bool IsPrime(long n)
        {
            if (n < 2)
            {
                return false;
            }
            for (long i = 2, limit = (long)Math.Sqrt(n); i <= limit; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine("{0} is{1}prime", n, IsPrime(n) ? " " : " not ");
        }
    }
}
