using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    class ForestRoad
    {
        static void Main()
        {
            byte n = byte.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write('.');
                }
                Console.Write('*');
                for (int j = 0; j < n-i-1; j++)
                {
                    Console.Write('.');
                }
                Console.WriteLine();
            }
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < n-i-1; j++)
                {
                    Console.Write('.');
                }
                Console.Write('*');
                for (int j = 0; j < i; j++)
                {
                    Console.Write('.');
                }
                Console.WriteLine();
            }
        }
    }
}
