using System;

namespace FibonacciNumbers
{
    class FibonacciNums
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int prev = 0, current = 1;
            if (n >= 1)
            {
                Console.Write("{0} ", prev);
                if (n >= 2)
                {
                    Console.Write("{0} ", current);
                    for (int i = 3; i <= n; i++)
                    {
                        current += prev;
                        prev = current - prev;
                        Console.Write("{0} ", current);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
