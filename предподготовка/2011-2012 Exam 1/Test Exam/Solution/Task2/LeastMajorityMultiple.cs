using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    class LeastMajorityMultiple
    {
        const byte N=5;
        const int MAX = 100;
        static void Main()
        {
            byte[] a = new byte[N];
            long max = 1;
            for (int i = 0; i < N; i++)
            {
                a[i] = byte.Parse(Console.ReadLine());
                max *= MAX;
            }
            byte c;
            for (long i = 4; i < max; i++)
            {
                c = 0;
                for (int j = 0; j < N; j++)
                {
                    if (i % a[j] == 0)
                    {
                        c++;
                    }
                }
                if (c >= 3)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
