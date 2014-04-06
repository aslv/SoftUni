using System;

namespace HexadecimalToDecimalNumber
{
    class HexToDec
    {
        static void Main()
        {
            string hexadecimalRepresentation = Console.ReadLine();
            ulong number = 0, power16 = 1UL;
            byte multiplier;
            for (int i = hexadecimalRepresentation.Length - 1; i >= 0; i--, power16 <<= 4)
            {
                if (char.IsDigit(hexadecimalRepresentation, i))
                {
                    multiplier = byte.Parse(hexadecimalRepresentation.Substring(i, 1));
                }
                else
                {
                    switch (hexadecimalRepresentation[i])
                    {
                        case 'A':
                        case 'a': multiplier = 10; break;
                        case 'B':
                        case 'b': multiplier = 11; break;
                        case 'C':
                        case 'c': multiplier = 12; break;
                        case 'D':
                        case 'd': multiplier = 13; break;
                        case 'E':
                        case 'e': multiplier = 14; break;
                        case 'F':
                        case 'f': multiplier = 15; break;
                        default: throw new ArgumentException("not valid hexadecimal digit");
                    }
                }
                number += multiplier * power16;
            }
            Console.WriteLine(number);
        }
    }
}
