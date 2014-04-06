using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem01_Odd_or_Even_Integers
{
    class Problem01_Odd_or_Even_Integers
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number % 2 == 0);
        }
    }
}
