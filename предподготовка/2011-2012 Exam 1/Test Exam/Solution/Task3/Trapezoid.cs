using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    class Trapezoid
    {
        static void Main()
        {
            byte n = byte.Parse(Console.ReadLine());

            for (byte i = 0; i < n; i++)
            {
                Console.Write('.');
            }
            for (byte i = 0; i < n; i++)
            {
                Console.Write('*');
            }
            Console.WriteLine();

            for (int i = n - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write('.');
                }
                Console.Write('*');
                for (int j = 0, len = (n << 1) - i - 2; j < len; j++)
                {
                    Console.Write('.');
                }
                Console.WriteLine('*');
            }

            for (int i = 0, len = n << 1; i < len; i++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }
    }
}
