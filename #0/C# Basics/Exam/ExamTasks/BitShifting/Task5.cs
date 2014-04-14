using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitShifting
{
    class Task5
    {
        static string ConvertTo2(ulong value)
        {
            ulong mask = 1ul << 127;
            string number = "";
            for (; mask > 0; mask >>= 1)
            {
                if ((value & mask) > 0)
                {
                    number += "1";
                }
                else
                {
                    number += "0";
                }
            }
            return number;
        }
        static void Main()
        {
            ulong current = ulong.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string[] bits = new string[n + 2];
            bits[0] = ConvertTo2(current);
            for (int i = 1; i <= n; i++)
            {
                current = ulong.Parse(Console.ReadLine());
                bits[i] = ConvertTo2(current);
            }
            int bitCount = 0;
            bool weHaveOne;
            /*
            Console.WriteLine();
            foreach (string num in bits)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
            */
            for (int col = 0; col < 64; col++)
            {
                if (bits[0][col] == '1')
                {
                    weHaveOne = true;
                }
                else
                {
                    weHaveOne = false;
                }
                if (!weHaveOne)
                {
                    continue;
                }
                for (int row = 1; row <= n; row++)
                {

                    if (bits[row][col] == '1')
                    {
                        weHaveOne = false;
                        break;
                    }
                }
                if (weHaveOne)
                {
                    bitCount++;
                }
            }
            Console.WriteLine(bitCount);
        }
    }
}
