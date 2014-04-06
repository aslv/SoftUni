using System;

namespace NumbersNotDivisibleBy3And7
{
    class NumsNotDiv3n7
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    continue;
                }
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}