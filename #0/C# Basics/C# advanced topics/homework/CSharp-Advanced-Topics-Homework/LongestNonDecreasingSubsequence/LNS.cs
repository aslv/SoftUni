using System;
using System.Collections.Generic;

namespace LongestNonDecreasingSubsequence
{
    class LNS
    {
        static void Main()
        {
            string[] values = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            int n = values.Length;
            long[] x = new long[n + 1];
            x[0] = long.MaxValue;
            for (int i = 1; i <= n; i++)
            {
                x[i] = long.Parse(values[i - 1]);
            }

            long[,] LNS = new long[n + 1, n + 1];
            // Initialising
            for (int k = 0; k <= n; k++)
            {
                for (int s = 1; s <= n; s++)
                {
                    LNS[k, s] = long.MaxValue;
                }
                LNS[k, 0] = long.MinValue;
            }
            // Main loop
            int r = 1;
            for (int k = 1; k <= n; k++)
            {
                for (int s = 1; s <= n; s++)
                {
                    if (LNS[k - 1, s - 1] <= x[k] && x[k] <= LNS[k - 1, s])
                    {
                        LNS[k, s] = x[k];
                        if (r < s)
                        {
                            r = s;
                        }
                    }
                    else
                    {
                        LNS[k, s] = LNS[k - 1, s];
                    }
                }
            }
            // Console.WriteLine("Len: {0}", r);
            int len = r, el = n;
            Stack<long> elements = new Stack<long>();
            do
            {
                if (LNS[el, len] == LNS[el - 1, len])
                {
                    el--;
                }
                else
                {
                    elements.Push(x[el]);
                    len--;
                }
            } while (el > 0);
            // Output
            while (elements.Count > 0)
            {
                Console.Write("{0} ", elements.Pop());
            }
            Console.WriteLine();
        }
    }
}