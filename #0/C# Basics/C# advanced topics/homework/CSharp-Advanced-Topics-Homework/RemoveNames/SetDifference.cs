using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNames
{
    class SetDifference
    {
        static void Main()
        {
            // Reading from console
            List<string> first = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
            List<string> second = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
            // Set difference (minus) operation
            var result = first.Except(second);
            // Output
            foreach (var element in result)
            {
                Console.Write("{0} ", element);
            }
            Console.WriteLine();
        }
    }
}
