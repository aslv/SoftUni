using System;
using System.Collections.Generic;

namespace CountOfNames
{
    class CountNames
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            SortedDictionary<string, int> count = new SortedDictionary<string, int>();
            foreach (string name in names)
            {
                if (count.ContainsKey(name))
                {
                    count[name]++;
                }
                else
                {
                    count[name] = 1;
                }
            }
            foreach (string name in count.Keys)
            {
                Console.WriteLine("{0} -> {1}", name, count[name]);
            }
        }
    }
}
