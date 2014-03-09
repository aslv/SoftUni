using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    class SandGlass
    {
        static void Main()
        {
            byte n = byte.Parse(Console.ReadLine());
            for (int i = 0, len = n / 2; i <= len; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write('.');
                }
                for (int j = 0, l = n - 2 * i; j < l; j++)
                {
                    Console.Write('*');
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write('.');
                }
                Console.WriteLine();
            }
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write('.');
                }
                for (int j = 0, l = n - 2 * i; j < l; j++)
                {
                    Console.Write('*');
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write('.');
                }
                Console.WriteLine();
            }
        }
    }
}
