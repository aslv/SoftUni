using System;

namespace ExtractBitNumber3
{
    class ExtractBit3
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            uint mask = 1 << 3;
            Console.WriteLine("Bit #3: {0}", (n & mask) == mask ? 1 : 0);
        }
    }
}
