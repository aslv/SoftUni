using System;

namespace BinaryToDecimalNumber
{
    class BinToDec
    {
        static void Main()
        {
            string binaryRepresentation = Console.ReadLine().PadLeft(64, '0');
            ulong number = 0, power2 = 1UL;
            for (int i = 0; i < 64; i++)
            {
                number += ulong.Parse(binaryRepresentation[63 - i].ToString()) * power2;
                unchecked
                {
                    power2 <<= 1;
                }
            }
            Console.WriteLine(number);
        }
    }
}
