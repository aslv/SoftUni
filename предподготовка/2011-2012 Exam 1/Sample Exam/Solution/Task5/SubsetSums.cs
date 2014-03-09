using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task5
{
    class SubsetSums
    {
        static long s;
        static byte n;
        static long[] a;
        static long count = 0;

        static void Sum(byte index, long sumSoFar)
        {
            if (sumSoFar + a[index] == s)
            {
                count++;
            }
            sumSoFar += a[index];
            for (byte i = (byte)(index + 1); i < n; i++)
            {
                Sum(i, sumSoFar);
            }
        }

        static void Main()
        {
            s = long.Parse(Console.ReadLine());
            n = byte.Parse(Console.ReadLine());
            a = new long[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = long.Parse(Console.ReadLine());
            }
            for (byte i = 0; i < n; i++)
            {
                Sum(i, 0);
            }
            Console.WriteLine(count);
        }
    }
}
