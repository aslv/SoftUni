using System;

namespace PontInCircAndOutOfRect
{
    class InCircOutRect
    {
        static void Main()
        {
            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            double y = double.Parse(Console.ReadLine());

            double x0 = 1, y0 = 1, r = 1.5;
            double top = 1, bottom = -1, left = -1, right = 5;

            double distRaised2 = (x - x0) * (x - x0) + (y - y0) * (y - y0);
            bool inCirc = distRaised2 <= r * r;

            bool outRect = x < left || x > right || y > top || y < bottom;

            Console.WriteLine("Is point ({0}, {1}) in the circle and out of the rectangle: {2}", x, y, inCirc && outRect);
        }
    }
}
