using System;
using System.Threading;

class PointInACircle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double radius = 2;

        bool isInsideCircle = (x * x + y* y <= radius * radius);
        Console.WriteLine(isInsideCircle);
        
    }
}

