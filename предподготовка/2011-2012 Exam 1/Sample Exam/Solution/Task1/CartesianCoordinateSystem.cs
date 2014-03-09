using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1
{
    class CartesianCoordinateSystem
    {
        static void Main()
        {
            double x, y;
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            int result = -1;

            if (x > 0)
            {
                if (y > 0)
                {
                    result = 1;
                }
                else if (y == 0)
                {
                    result = 6;
                }
                else
                {
                    result = 4;
                }
            }
            else if (x == 0)
            {
                if (y == 0)
                {
                    result = 0;
                }
                else
                {
                    result = 5;
                }
            }
            else
            {
                if (y > 0)
                {
                    result = 2;
                }
                else if (y == 0)
                {
                    result = 6;
                }
                else
                {
                    result = 3;
                }
            }
            Console.WriteLine(result);
        }
    }
}
