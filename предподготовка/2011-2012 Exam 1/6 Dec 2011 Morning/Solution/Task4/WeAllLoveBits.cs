using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4
{
    class WeAllLoveBits
    {
        static uint[] power = new uint[]
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
            1073741824
        };
        static uint Inverted(uint a)
        {
            bool f = false;
            List<sbyte> l = new List<sbyte>();
            for (sbyte i = (sbyte)(power.Length - 1); i >= 0; i--)
            {
                if ((a & power[i]) == power[i])
                {
                    f = true;
                    l.Add(1);
                }
                else
                {
                    if (f)
                    {
                        l.Add(0);
                    }
                }
            }
            for (int i = l.Count - 1; i >= 0; i--)
            {
                l[i] = (l[i] == 0) ? (sbyte)1 : (sbyte)0;
            }
            while (l[0] == 0)
            {
                l.RemoveAt(0);
            }
            uint result = 0;
            for (int i = 0; i < l.Count; i++)
            {
                result += (uint)(l[i] * power[i]);
            }
            return result;
        }
        static uint Reversed(uint a)
        {
            bool f = false;
            List<sbyte> l = new List<sbyte>();
            for (sbyte i = 30; i >= 0; i--)
            {
                if ((a & power[i]) == power[i])
                {
                    f = true;
                    l.Add(1);
                }
                else
                {
                    if (f)
                    {
                        l.Add(0);
                    }
                }
            }
            l.Reverse();
            while (l[0] == 0)
            {
                l.RemoveAt(0);
            }
            l.Reverse(); // !

            uint result = 0;
            for (int i = 0; i < l.Count; i++)
            {
                result += (uint)(l[i] * power[i]);
            }
            return result;
        }

        static void Main()
        {
            short n = short.Parse(Console.ReadLine());
            uint[] a = new uint[n];
            for (short i = 0; i < n; i++)
            {
                a[i] = uint.Parse(Console.ReadLine());
            }
            for (short i = 0; i < n; i++)
            {
                // Console.WriteLine((a[i] ^ Inverted(a[i])) & Reversed(a[i]));
                Console.WriteLine(Reversed(a[i]));
            }
        }
    }
}
