using System;

namespace ModifyABitAtGivenPosition
{
    class ModifyBit
    {
        static void Main()
        {
            Console.Write("Number: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Position: ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Bit: ");
            int v = int.Parse(Console.ReadLine());

            int mask;
            if (v == 1)
            {
                mask = 1 << p;
                n |= mask;
            }
            else
            {
                mask = int.MaxValue - (1 << p);
                n &= mask;
            }
            Console.WriteLine("Result: {0}", n);
        }
    }
}
