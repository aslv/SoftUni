using System;

namespace DecimalToHexadecimalNumber
{
    class DecToHex
    {
        static char[] hexDigits = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        static void Main()
        {
            ulong decimalRepresentation = ulong.Parse(Console.ReadLine());
            string number = "";
            ulong power16 = 1UL << 63;
            for (int i = 15; i >= 0; i--)
            {
                /**/power16 = 1UL << (i*4);
                if (decimalRepresentation >= power16)
                {
                    number += hexDigits[decimalRepresentation / power16];
                    decimalRepresentation %= power16;
                }
                else
                {
                    number += hexDigits[0];
                }
                //power16 >>= 4;
            }
            Console.WriteLine(number.TrimStart('0'));
        }
    }
}
