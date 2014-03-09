using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4
{
    class BinaryDigitsCount
    {
        static uint[] degrees = new uint[]
        {
            1,
            2,
            4,
            8,
            16,
            32,
            64,
            128,
            256,
            512,
            1024,
            2048,
            4096,
            8192,
            16384,
            32768,
            65536,
            131072,
            262144,
            524288,
            1048576,
            2097152,
            4194304,
            8388608,
            16777216,
            33554432,
            67108864,
            134217728,
            268435456,
            536870912,
            1073741824,
            2147483648
        };
        static byte b;

        static byte DigitsCount(uint number)
        {
            byte degree = 0;
            for (byte i = 31; i > 0; i--)
            {
                if (number > degrees[i])
                {
                    degree = i;
                    break;
                }
                else if (number == degrees[i])
                {
                    if (b == 0)
                    {
                        return i;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
            byte counts1 = 0;
            for (int i = degree; i >= 0; i--)
            {
                if (degrees[i] < number)
                {
                    counts1++;
                    number -= degrees[i];
                }
                else if (degrees[i] == number)
                {
                    counts1++;
                    break;
                }
            }
            if (b == 0)
            {
                return (byte)(degree - counts1 + 1);
            }
            return counts1;
        }

        static void Main()
        {
            b = byte.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            uint[] a = new uint[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = uint.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(DigitsCount(a[i]));
            }
        }
    }
}
