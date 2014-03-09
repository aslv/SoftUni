using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4
{
    class OddNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            long[] a = new long[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = long.Parse(Console.ReadLine());
            }

            long result = a[0];
            for (int i = 1; i < n; i++)
            {
                result ^= a[i];
            }
            Console.WriteLine(result);
        }
    }
}
