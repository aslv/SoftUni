using System;
using System.Collections.Generic;

class PerimeterAndAreaOfPolygon
{
    static void Main()
    {
        /* 17. Write a program that calculates the perimeter and the area of given polygon (not necessarily
         * convex) consisting of n floating-point coordinates in the 2D plane. Print the result rounded to two 
         * decimal digits after the decimal point. Use the input and output format from the examples. To hold 
         * the points, define a class Point(x, y). To hold the polygon use a Polygon class which holds a list of
         * points. Find in Internet how to calculate the polygon perimeter and how to calculate the area of a 
         * polygon. Examples:
         * 
         * Input | Output
         * 3     | perimeter = 3.41
         * 0 0   | area = 0.50
         * 0 1   |
         * 1 1   |
         * 
         * Input | Output
         * 7     | perimeter = 22.64
         * -2 1  | area = 9.5
         * 1 3   |
         * 5 1   |
         * 1 2   |
         * 1 1   |
         * 3 -2  |
         * -2 1  |
         */

        Console.Write("Enter number of points: ");
        int n = int.Parse(Console.ReadLine());

        Polygon pol = new Polygon();
        pol.Point = new List<Points>();
        
        //pol.Point = new List<Points> {
        //                                new Points { X = -2, Y = 1 },
        //                                new Points { X = 1, Y = 3 },
        //                                new Points { X = 5, Y = 1 },
        //                                new Points { X = 1, Y = 2 },
        //                                new Points { X = 1, Y = 1 },
        //                                new Points { X = 3, Y = -2 },
        //                                new Points { X = -2, Y = 1 }
        //                              };

        for (int i = 0; i < n; i++)
        {
            Points p = new Points();
            string point = Console.ReadLine();
            string[] coordinates = point.Split(' ');
        
            p.X = Convert.ToDouble(coordinates[0]);
            p.Y = Convert.ToDouble(coordinates[1]);
        
            pol.Point.Add(p);
        }

        double perimeter = 0;
        double area = 0;

        for (int i = 0; i < pol.Point.Count - 1; i++)
        {
            perimeter += CalcDistance(pol.Point[i].X, pol.Point[i].Y, pol.Point[i + 1].X, pol.Point[i + 1].Y);
        }

        for (int i = 0; i < pol.Point.Count; i++)
        {
            if (i == pol.Point.Count - 1)
            {
                area += ((pol.Point[i].X * pol.Point[0].Y) - (pol.Point[i].Y * pol.Point[0].X));

                if (area < 0)
                {
                    area = (area * -1) / 2;
                }
                else
                {
                    area = area / 2;
                }
            }
            else
            {
                area += ((pol.Point[i].X * pol.Point[i + 1].Y) - (pol.Point[i].Y * pol.Point[i + 1].X));
            }
        }
        
        if (pol.Point[0].X == pol.Point[pol.Point.Count - 1].X &&
            pol.Point[0].Y == pol.Point[pol.Point.Count - 1].Y)
        {
            Console.WriteLine("perimeter = {0:F2}", perimeter);
            Console.WriteLine("area = {0:F2}", area);
        }
        else
        {
            Console.WriteLine("lenght = {0:F2}", perimeter);
        }
        
        //foreach (var item in pol.Point)
        //{
        //    Console.WriteLine("{0}, {1}", item.X, item.Y);
        //}
    }

    static double CalcDistance(double x1, double y1, double x2, double y2)
    {
        double dx = x2 - x1;
        double dy = y2 - y1;
        double distance = Math.Sqrt(dx * dx + dy * dy);
        return distance;
    }
}