using System;

namespace PrimeNumberCheck
{
    class IsPrime
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool isPrime = true;
            for (int divisor = 2, maxTry = (int)Math.Sqrt(n); divisor <= maxTry; divisor++)
            {
                if (n % divisor == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine("{0} is {1}prime.", n, isPrime ? "" : "not ");
        }
    }
}