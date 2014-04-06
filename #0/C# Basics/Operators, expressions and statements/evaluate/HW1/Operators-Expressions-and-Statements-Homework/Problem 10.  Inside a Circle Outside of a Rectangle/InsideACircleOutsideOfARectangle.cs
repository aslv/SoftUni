using System;

namespace Problem_10.Inside_a_Circle_Outside_of_a_Rectangle
{
    class InsideACircleOutsideOfARectangle
    {
        static void Main()
        {
            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            double y = double.Parse(Console.ReadLine());

            bool isInCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= (1.5 * 1.5);
            bool isOutsideRectangle = x > 1 || x < 6 && y > -1 || y < 2;

            if (x == 0 || y == 0)
            {
                Console.WriteLine("no");
            }
            else if (isInCircle == true && isOutsideRectangle == true)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
