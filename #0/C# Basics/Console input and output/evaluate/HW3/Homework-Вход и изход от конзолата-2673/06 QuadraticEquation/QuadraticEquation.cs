using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Please enter coefficient a of the quadratic equation: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter coefficient b of the quadratic equation: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter coefficient c of the quadratic equation: ");
        double c = double.Parse(Console.ReadLine());
        double d;
        double root1;
        double root2;

        d = b * b - 4 * a * c;

        if (d < 0)
        {
            Console.WriteLine("No roots for the equation!"); 
        }
        else if (d == 0)
        {
            root1 = -b / a * 2;
            Console.WriteLine("The equation has only one root which is {0}", root1);
        }
        else
        {
            root1 = (-b - Math.Sqrt(d)) / (a * 2);
            root2 = (-b + Math.Sqrt(d)) / (a * 2);
            Console.WriteLine("The roots of the equation are:\nX1 = {0}\nX2 = {1}", root1, root2);
        }
    }
}

