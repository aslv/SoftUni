using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.Bitwise_Extract_Bit_3
{
    class BitwiseExtractBit3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number: ");
            int number = int.Parse(Console.ReadLine());

            int fakeBit = 1 << 3;
            int foundBit = number & fakeBit;

            if (foundBit == 0)
            {
                Console.WriteLine("Third bit is '0' " + Convert.ToString(number, 2).PadLeft(16, '0'));
            }
            else
            {
                Console.WriteLine("Third bit is '1' " + Convert.ToString(number, 2).PadLeft(16, '0'));
            }
        }
    }
}
