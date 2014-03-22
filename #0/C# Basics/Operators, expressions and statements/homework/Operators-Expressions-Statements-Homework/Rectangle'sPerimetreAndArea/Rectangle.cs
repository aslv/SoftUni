using System;

namespace Rectangle_sPerimetreAndArea
{
    class Rectangle
    {
        static void Main()
        {
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Perimetre: {0}", 2 * (width + height));
            Console.WriteLine("Area: {0}", width * height);
        }
    }
}
