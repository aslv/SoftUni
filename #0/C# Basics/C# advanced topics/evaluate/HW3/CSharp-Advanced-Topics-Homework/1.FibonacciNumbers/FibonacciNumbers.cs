using System;

class FibonacciNumbers
{
    static void Main()
    {
        /* 1. Define a method Fib(n) that calculates the n-th Fibonacci number. 
         * Examples:
         * 
         *  n  |  Fib(n)
         *  0  |       1
         *  1  |       1
         *  2  |       2
         *  3  |       3
         *  4  |       5
         *  5  |       8
         *  6  |      13
         * 11  |     144
         * 25  |  121393
         */

        Console.Write("Enter n = ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0} Fibonacci's number is: {1}", n, FibNumber(n));
    }

    static ulong FibNumber(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            ulong f1 = 0;
            ulong f2 = 1;
            ulong temp = 0;
            ulong sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum = f1 + f2;
                temp = f1;
                f1 = f2;
                f2 = sum;
            }

            return sum;
        }
    }
}