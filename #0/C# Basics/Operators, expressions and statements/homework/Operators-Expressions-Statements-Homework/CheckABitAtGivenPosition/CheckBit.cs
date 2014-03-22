using System;

namespace CheckABitAtGivenPosition
{
    class CheckBit
    {
        static void Main()
        {
            Console.Write("Number: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Position: ");
            int p = int.Parse(Console.ReadLine());

            int mask = 1 << p;
            Console.WriteLine("Bit at position {0} is 1? -> {1}", p, (n & mask) == mask);
        }
    }
}
