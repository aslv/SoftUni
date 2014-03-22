using System;

namespace PointInACircle
{
    class PointCirc
    {
        static void Main()
        {
            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            double y = double.Parse(Console.ReadLine());
            double x0 = 0, y0 = 0, r = 2;
            double distRaised2 = (x - x0) * (x - x0) + (y - y0) * (y - y0);
            bool inOrAtBorder = distRaised2 <= r * r;
            Console.WriteLine("The point ({0}, {1}) is in the circle: {2}", x, y, inOrAtBorder);
        }
    }
}
