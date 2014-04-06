using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem04_Rectangles
{
    class Problem04_Rectangles
    {
        static void Main(string[] args)
        {
            Console.Write("Please rectangle's width: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Please rectangle's height: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Perimeter: {0}", 2*(a+b));
            Console.WriteLine("Area: {0}", (a*b));
        }
    }
}
