using System;
using System.Collections.Generic;

namespace PerimetreAndAreaOfPolygon
{
    public class CalculatePerimetreAndSurface
    {
        private class Point
        {
            private double x, y;

            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }

            public double X
            {
                get
                {
                    return this.x;
                }
                set
                {
                    try
                    {
                        this.x = value;
                    }
                    catch (InvalidCastException)
                    {
                        Console.Error.WriteLine("Invalid argument value of `X'");
                    }
                    
                }
            }
            public double Y
            {
                get
                {
                    return this.y;
                }
                set
                {
                    try
                    {
                        this.y = value;
                    }
                    catch (InvalidCastException)
                    {
                        Console.Error.WriteLine("Invalid argument value of `Y'");
                    }
                }
            }
            public double DistanceTo(Point point)
            {
                return Math.Sqrt((this.X - point.X) * (this.X - point.X) + (this.Y - point.Y) * (this.Y - point.Y));
            }
        }

        private class Polygon
        {
            private List<Point> points;

            public Polygon()
            {
                points = new List<Point>();
            }
            public Polygon(params Point[] points)
            {
                this.points = new List<Point>(points);
            }
            public Polygon(List<Point> points)
            {
                this.points = new List<Point>(points);
            }

            public double GetPerimetre()
            {
                points.Add(points[0]);
                double result = 0;
                for (int i = 0; i < points.Count - 1; i++)
                {
                    result += points[i].DistanceTo(points[i + 1]);
                }
                points.RemoveAt(points.Count - 1);
                return result;
            }
            public double GetArea()
            {
                points.Add(points[0]);
                double result = 0;
                for (int i = 0; i < points.Count - 1; i++)
                {
                    result += points[i].X * points[i + 1].Y - points[i].Y * points[i + 1].X;
                }
                points.RemoveAt(points.Count - 1);
                result = Math.Abs(result / 2);
                return result;
            }
        }

        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Now enter {0} points (described with their coordiantes (x and y) :", n);
            string[] values;
            List<Point> points = new List<Point>();
            for (int i = 0; i < n; i++)
            {
                values = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                points.Add(new Point(double.Parse(values[0]), double.Parse(values[1])));
            }
            Polygon poly = new Polygon(points);
            Console.WriteLine("\nperimetre = {0:f2}\narea = {1:f2}", poly.GetPerimetre(), poly.GetArea());
        }
    }
}
