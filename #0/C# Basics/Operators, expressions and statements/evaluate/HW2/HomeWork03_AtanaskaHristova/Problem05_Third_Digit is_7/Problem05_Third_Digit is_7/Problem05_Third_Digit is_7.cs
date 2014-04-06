using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem05_Third_Digit_is_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number to check: " );
            int a = int.Parse(Console.ReadLine());
            a = (a / 100);
            Console.WriteLine(a % 10 == 7);

            
        }
    }
}
