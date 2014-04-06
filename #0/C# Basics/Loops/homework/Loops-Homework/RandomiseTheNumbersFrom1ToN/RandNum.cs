using System;
using System.Collections.Generic;

namespace RandomiseTheNumbersFrom1ToN
{
    class RandNum
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                list.Add(i);
            }
            Random rand = new Random();
            int index;
            for (int i = n; i > 0; i--)
            {
                index = rand.Next(i);
                Console.Write("{0} ", list[index]);
                list.RemoveAt(index);
            }
            Console.WriteLine();
        }
    }
}
