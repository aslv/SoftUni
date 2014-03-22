using System;

namespace QuadraticEquation
{
    class QuadEquation
    {
        static void Main()
        {
            Console.Write("ax^2 + bx + c = 0\na = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("every x is a solution");
                    }
                    else
                    {
                        Console.WriteLine("no x is a solution");
                    }
                }
                else
                {
                    Console.WriteLine("One root: x = {0}", -c / b);
                }
            }
            else
            {
                double d = b * b - 4 * a * c;
                if (d > 0)
                {
                    d = Math.Sqrt(d);
                    Console.WriteLine("Two roots: x1 = {0} and x2 = {1}", (-b - d) / (2 * a), (-b + d) / (2 * a));
                }
                else if (d == 0)
                {
                    Console.WriteLine("One double root: x1 = x2 = {0}", -b / (2 * a));
                }
                else
                {
                    d = Math.Sqrt(-d);
                    Console.WriteLine("Two complex roots: x1 = {0}+{1}i and {0}-{1}i", -b / (2 * a), d / (2 * a));
                }
            }
        }
    }
}
