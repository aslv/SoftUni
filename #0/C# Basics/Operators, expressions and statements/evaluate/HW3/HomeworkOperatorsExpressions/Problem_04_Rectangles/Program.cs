using System;
using System.Threading;

class Rectangles
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        decimal width = decimal.Parse(Console.ReadLine());
        decimal height = decimal.Parse(Console.ReadLine());
        decimal area = width * height;
        decimal perimeter = 2 * (width + height);
        Console.WriteLine("{0} , {1}",perimeter, area);
    }
}

