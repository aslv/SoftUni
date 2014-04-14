using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_3___Cicle_Perimeter_and_Area
{
    class PerimeterArea
    {
        static void Main(string[] args)
        {
            double r;
            do
            {
                Console.Write("Input radius: ");
                r = double.Parse(Console.ReadLine());
                double perimeter = 2 * 3.14 * r;
                double area = 3.14 * r * r;
                Console.WriteLine("Perimeter: {0:#.##}", perimeter);
                Console.WriteLine("Area: {0:#.##}", area);
            }
            while (true);
        }
    }
}
