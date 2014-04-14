using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Please enter first integer a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter first integer b: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine(a > b? a : b);
    }
}

