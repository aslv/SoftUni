using System;

namespace BitManipulation
{
    public static class ExchangeBits
    {
        public static byte GetBit(uint number, byte position)
        {
            int mask = 1 << position;
            if ((number & mask) == (uint)mask)
            {
                return 1;
            }
            return 0;
        }
        public static void SetBit(ref uint number, byte position, byte bit)
        {
            uint mask;
            if (bit == 1)
            {
                mask = (uint)(1 << position);
                number |= mask;
            }
            else
            {
                mask = uint.MaxValue - (uint)(1 << position);
                number &= mask;
            }
        }
    }
}