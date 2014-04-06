using System;

namespace Problem_7.Point_in_a_Circle
{
    class PointInACircle
    {
        static void Main()
        {
            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            double y = double.Parse(Console.ReadLine());
            bool isInside = (x * x) + (y * y) <= (2 * 2);
            Console.WriteLine("The given point is inside the circle. -> " + isInside);
        }
    }
}
