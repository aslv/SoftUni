using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Please enter the radius of the circle r: ");
        double r = double.Parse(Console.ReadLine());

        double perimeter = (Math.PI * 2 * r);
        double area = (Math.PI * r * r);

        Console.WriteLine("The perimeter of the circle is {0 :0.00} and its area is {1 :0.00}", perimeter, area);
    }
}
