using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task5
{
    class Pillars
    {
        const byte N = 8;
        static byte[] power = new byte[] { 1, 2, 4, 8, 16, 32, 64, 128 };
        static void Main()
        {
            byte[] a = new byte[N];
            for (int i = 0; i < N; i++)
            {
                a[i] = byte.Parse(Console.ReadLine());
            }

            byte[] cells = new byte[power.Length];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < power.Length; j++)
                {
                    if ((a[i] & power[j]) == power[j])
                    {
                        cells[j]++;
                    }
                }
            }

            int position = power.Length, count = -1, currentLeft, currentRight;
            for (int i = power.Length - 1; i >= 0; i--)
            {
                currentLeft = currentRight = 0;
                for (int j = 0; j < i; j++)
                {
                    currentLeft += cells[j];
                }
                for (int j = i + 1; j < power.Length; j++)
                {
                    currentRight += cells[j];
                }
                if (currentLeft == currentRight)
                {
                    position = i;
                    count = currentRight;
                    break;
                }
            }

            if (count == -1)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("{0}\n{1}", position, count);
            }
        }
    }
}