using System;
using BitManipulation;

namespace BitsExchange
{
    class BitSwap
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());

            byte[] juniorBits = new byte[3];
            byte[] seniorBits = new byte[3];

            juniorBits[0] = ExchangeBits.GetBit(n, 3);
            juniorBits[1] = ExchangeBits.GetBit(n, 4);
            juniorBits[2] = ExchangeBits.GetBit(n, 5);

            seniorBits[0] = ExchangeBits.GetBit(n, 24);
            seniorBits[1] = ExchangeBits.GetBit(n, 25);
            seniorBits[2] = ExchangeBits.GetBit(n, 26);

            ExchangeBits.SetBit(ref n, 3, seniorBits[0]);
            ExchangeBits.SetBit(ref n, 4, seniorBits[1]);
            ExchangeBits.SetBit(ref n, 5, seniorBits[2]);

            ExchangeBits.SetBit(ref n, 24, juniorBits[0]);
            ExchangeBits.SetBit(ref n, 25, juniorBits[1]);
            ExchangeBits.SetBit(ref n, 26, juniorBits[2]);

            Console.WriteLine(n);
        }
    }
}
