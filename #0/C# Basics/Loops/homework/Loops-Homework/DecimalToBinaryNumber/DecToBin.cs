using System;

namespace DecimalToBinaryNumber
{
    class DecToBin
    {
        static void Main()
        {
            ulong decimalRepresentation = ulong.Parse(Console.ReadLine());
            string number = "";
            ulong power2 = 1UL << 63;
            for (int i = 63; i >= 0; i--)
            {
                if (decimalRepresentation >= power2)
                {
                    number += '1';
                    decimalRepresentation -= power2;
                }
                else
                {
                    number += '0';
                }
                power2 >>= 1;
            }
            Console.WriteLine(number.TrimStart('0'));
        }
    }
}
