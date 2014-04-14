using System;

    class CirclePerimeterAndArea
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("The perimeter f circle is: {0:F2}", Math.PI * 2 * r);
            Console.WriteLine("The area of circle is: {0:F2}", Math.PI * r * r);
        }
    }
