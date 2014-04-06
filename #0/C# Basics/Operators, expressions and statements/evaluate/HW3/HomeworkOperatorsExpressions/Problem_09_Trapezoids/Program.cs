using System;
using System.Threading;

class Trapezoids
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        double sideA = double.Parse(Console.ReadLine());
        double sideB = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double area = ((sideA + sideB) * height) / 2;
        Console.WriteLine(area);
    }
}

