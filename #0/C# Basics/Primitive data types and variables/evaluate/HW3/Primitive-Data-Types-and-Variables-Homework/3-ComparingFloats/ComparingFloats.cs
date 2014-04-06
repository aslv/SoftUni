using System;

class ComparingFloats
{
    static void Main()
    {
        Console.Write("First Number: ");
        decimal A = decimal.Parse(Console.ReadLine());
        Console.Write("Second Number: ");
        decimal B = decimal.Parse(Console.ReadLine());
        decimal eps = 0.000001M;
        decimal difference = A > B ? A - B : B - A;
        bool equal = difference < eps;
        Console.WriteLine("A == B: " + equal);
    }
}