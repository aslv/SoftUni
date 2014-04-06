using System;
using System.Collections.Generic;
using System.Linq;

namespace JoinLists
{
    class SetUnion
    {
        static void Main()
        {
            string[] values;
            long[] first, second;
            values = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            first = new long[values.Length];
            for (int i = 0; i < first.Length; i++)
            {
                first[i] = long.Parse(values[i]);
            }
            values = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            second = new long[values.Length];
            for (int i = 0; i < second.Length; i++)
            {
                second[i] = long.Parse(values[i]);
            }

            long[] result = first.Union(second).ToArray<long>();
            Array.Sort(result);

            foreach (long element in result)
            {
                Console.Write("{0} ", element);
            }
            Console.WriteLine();
        }
    }
}
