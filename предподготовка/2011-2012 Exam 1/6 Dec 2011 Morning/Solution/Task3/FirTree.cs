using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    class FirTree
    {
        static void Main()
        {
            byte n = byte.Parse(Console.ReadLine());
            for (int i = n - 2; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write('.');
                }
                for (int j = 2 * n - 3; j > 2*i; j--)
                {
                    Console.Write('*');
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write('.');
                }
                Console.WriteLine();
            }
            for (int i = n - 2; i > 0; i--)
            {
                Console.Write('.');
            }
            Console.Write('*');
            for (int i = n - 2; i > 0; i--)
            {
                Console.Write('.');
            }
            Console.WriteLine();
        }
    }
}
