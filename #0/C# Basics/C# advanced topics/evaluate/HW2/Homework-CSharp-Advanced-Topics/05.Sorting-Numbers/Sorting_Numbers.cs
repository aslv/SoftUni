using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Sorting_Numbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter number to create sequence of n numbers: ");
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter sequence of n numbers: ");
        int[] number = new int[n];

        for (int i = 0; i < n; i++)
        {
            number[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(number);
        Console.WriteLine("Output: ");
        foreach (var item in number)
        {
            Console.WriteLine("   " + item);
        }
    }
}