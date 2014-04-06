using System;

namespace Problem_4.Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            Console.WriteLine("The width of the rectangle is: ");
            Console.WriteLine("The height of the rectangle is: ");
            float width = float.Parse(Console.ReadLine());
            float height = float.Parse(Console.ReadLine());
            float perimeter = 2 * width + 2 * height;
            Console.WriteLine("The perimeter of the rectangle is: " + perimeter);
            float area = width * height;
            Console.WriteLine("The area of the rectangle is: " + area);
        }
    }
}