using System;
using System.Threading;

class Problem_10_PointInsideCircleOutsideRect
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        double coordinateX = double.Parse(Console.ReadLine());
        double coordinateY = double.Parse(Console.ReadLine());
        double radius = 1.5;
        double centerX = 1;
        double centerY = 1;
        bool pointInCircle = ((coordinateX - centerX) * (coordinateX - centerX) + (coordinateY - centerY) * (coordinateY - centerY)) <= (radius * radius);
        bool pointInRectangle = ((-1 <= coordinateX) && (coordinateX <= 5)) && ((-1 <= coordinateY) && (coordinateY <= 1));


        if (pointInCircle)
        {
            if (pointInRectangle)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine("yes");
            }
        }
        else
        {
            Console.WriteLine("no");
        }

    }
}

