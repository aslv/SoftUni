using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task5
{
    class FallDown
    {
        const byte N = 8;
        static byte[] positions = new byte[] { 1, 2, 4, 8, 16, 32, 64, 128 };

        static void Main()
        {
            byte input;
            byte[] count = new byte[N];
            for (int i = 0; i < N; i++)
            {
                input = byte.Parse(Console.ReadLine());
                for (int j = 0; j < N; j++)
                {
                    if ((input & positions[j]) == positions[j])
                    {
                        count[j]++;
                    }
                }
            }
            byte[] result = new byte[N];
            for (int i = N - 1; i >= 0; i--)
            {
                for (int j = 0; j < N; j++)
                {
                    if (count[j] > 0)
                    {
                        result[i] += positions[j];
                        count[j]--;
                    }
                }
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
