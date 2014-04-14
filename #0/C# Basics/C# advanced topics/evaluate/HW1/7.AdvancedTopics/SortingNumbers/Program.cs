using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingNumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Program that reads a number n and a sequence of n integers, sorts them and prints them.");
            Console.WriteLine("Write n = ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            Console.WriteLine("Write {0} numbers:", n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Write number {0}", i+1);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort<int>(numbers);
            Console.WriteLine("The sorted numbers are:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
