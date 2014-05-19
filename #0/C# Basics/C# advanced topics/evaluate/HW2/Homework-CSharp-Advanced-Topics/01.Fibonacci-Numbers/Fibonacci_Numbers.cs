using System;
using System.Numerics;

class Fibonacci_Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter number n ");
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Fib(n);
    }

    static void Fib(int n)
    {
        BigInteger fibOne = 0;
        BigInteger fibTwo = 1;
        BigInteger sum = 0;
        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine(sum);
            sum = fibOne + fibTwo;
            fibTwo = fibOne;
            fibOne = sum;
        }
    }
}