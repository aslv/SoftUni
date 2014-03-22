using System;
using BitManipulation;

namespace BitsExchangeAdvanced
{
    class BitSwapAdvanced
    {
        static void Main()
        {
            Console.Write("n = ");
            uint n = uint.Parse(Console.ReadLine());
            Console.Write("p = ");
            byte p = byte.Parse(Console.ReadLine());
            Console.Write("q = ");
            byte q = byte.Parse(Console.ReadLine());
            Console.Write("k = ");
            byte k = byte.Parse(Console.ReadLine());

            if (p > q)
            {
                p += q;
                q = (byte)(p - q);
                p -= q;
            }
            if (p + k > q)
            {
                Console.Error.WriteLine("overlapping");
                return;
            }
            if (p < 0 || q + k > 32)
            {
                Console.Error.WriteLine("out of range");
                return;
            }

            byte[] juniorBits = new byte[k];
            byte[] seniorBits = new byte[k];

            for (byte i = p, e = (byte)(p + k); i < e; i++)
            {
                juniorBits[i - p] = ExchangeBits.GetBit(n, i);
            }
            for (byte i = q, e=(byte)(q+k); i < e; i++)
            {
                seniorBits[i - q] = ExchangeBits.GetBit(n, i);
            }

            for (byte i = p, e = (byte)(p + k); i < e; i++)
            {
                ExchangeBits.SetBit(ref n, i, seniorBits[i-p]);
            }
            for (byte i = q, e = (byte)(q + k); i < e; i++)
            {
                ExchangeBits.SetBit(ref n, i, juniorBits[i - q]);
            }

            Console.WriteLine(n);
        }
    }
}
