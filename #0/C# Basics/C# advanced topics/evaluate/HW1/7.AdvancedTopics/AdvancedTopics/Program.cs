using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FibonacciNumbers
{
    class Program
    {
        static int Fib(int n)
        {
            int n0 = 0;
            int n1 = 1;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = n0 + n1;
                n0 = n1;
                n1 = sum;
            }
            return sum;
        }

        static void Main()
        {
            Console.WriteLine("Program that calculates the n-th Fibonacci number.");
            Console.WriteLine("Write n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The n-th Fibonacci number is "+Program.Fib(n));
        }
    }
}
