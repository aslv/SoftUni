using System;

namespace MatrixOfNumbers
{
    class Matrix
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < i + n; j++)
                {
                    Console.Write("{0,2} ", j);
                }
                Console.WriteLine();
            }
        }
    }
}
