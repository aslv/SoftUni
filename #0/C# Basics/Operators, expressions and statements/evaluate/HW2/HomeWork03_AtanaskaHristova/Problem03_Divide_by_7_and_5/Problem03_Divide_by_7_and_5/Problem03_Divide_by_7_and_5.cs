using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem03_Divide_by_7_and_5
{
    class Problem03_Divide_by_7_and_5
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter number to check: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine((n % 5 == 0) && (n % 7 == 0));
        }
    }
}
