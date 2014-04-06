using System;
using System.Collections.Generic;

namespace AverageTimeLoadCalculator
{
    class TimeCalc
    {
        public class Pair<T, U>
        {
            public T First { get; set; }
            public U Second { get; set; }

            public Pair()
            {
            }

            public Pair(T first, U second)
            {
                this.First = first;
                this.Second = second;
            }
        };
        static void Main()
        {
            Console.WriteLine("You can terminate the entering by entering an empty line!");
            string line = Console.ReadLine();
            string[] parts;
            Dictionary<string, Pair<double, int>> sites = new Dictionary<string, Pair<double, int>>();
            while (line != null && line != "")
            {
                parts = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                if (sites.ContainsKey(parts[2]))
                {
                    sites[parts[2]].First += double.Parse(parts[3]);
                    sites[parts[2]].Second++;
                }
                else
                {
                    sites[parts[2]] = new Pair<double, int>(double.Parse(parts[3]), 1);
                }
                line = Console.ReadLine();
            }
            foreach (var site in sites)
            {
                Console.WriteLine("{0} -> {1}", site.Key, site.Value.First / site.Value.Second);
            }
        }
    }
}
