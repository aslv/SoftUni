using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeChecker
{
    class Program
    {
        static bool IsPrime(long n)
        {
            if (n < 2)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i ++)
                {
                    if (n % i == 0) return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Program that check whether a given integer number n is prime.");
            Console.WriteLine("Write n = ");
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine("Is number {0} prime ? {1} !", n, Program.IsPrime(n));
        }
    }
}
