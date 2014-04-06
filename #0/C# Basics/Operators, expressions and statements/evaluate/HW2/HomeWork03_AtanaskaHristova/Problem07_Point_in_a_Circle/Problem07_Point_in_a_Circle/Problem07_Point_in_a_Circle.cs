using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem07_Point_in_a_Circle
{
    class Problem07_Point_in_a_Circle
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter x: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter y: ");
            double y = double.Parse(Console.ReadLine());
            double d = Math.Sqrt((x*x) + (y*y));
            Console.WriteLine(d <= 2);
            
        }
    }
}
