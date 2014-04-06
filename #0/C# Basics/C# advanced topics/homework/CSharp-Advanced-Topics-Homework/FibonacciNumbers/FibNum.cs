using System;

namespace FibonacciNumbers
{
    class FibNum
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int prev = 1, current = 1;
            for (int i = 2; i <= n; i++)
            {
                current += prev;
                prev = current - prev;
            }
            Console.WriteLine("{0}-th Fibonacci number is {1}", n, current);
        }
    }
}
