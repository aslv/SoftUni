using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheExplorer
{
    class Task3
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new string('-', n >> 1));
            Console.Write('*');
            Console.WriteLine(new string('-', n >> 1));
            for (int i = (n >> 1) - 1, j = 1; i >= 0; i--, j += 2)
            {
                Console.Write(new string('-', i));
                Console.Write('*');
                Console.Write(new string('-', j));
                Console.Write('*');
                Console.WriteLine(new string('-', i));
            }
            for (int i = 1, j = n - 4; i < (n >> 1); i++, j -= 2)
            {
                Console.Write(new string('-', i));
                Console.Write('*');
                Console.Write(new string('-', j));
                Console.Write('*');
                Console.WriteLine(new string('-', i));
            }
            Console.Write(new string('-', n >> 1));
            Console.Write('*');
            Console.WriteLine(new string('-', n >> 1));
        }
    }
}
