using System;

class SumOfFiveNumbers
{
    static void Main()
    {
        Console.Write("Please enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter third number: ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("Please enter fourth number: ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("Please enter fifth number: ");
        double e = double.Parse(Console.ReadLine());

        double sum = a + b + c + d + e;
        Console.WriteLine("{0} {1} {2} {3} {4} and the sum of all is: {5}", a, b, c, d, e, sum);
    }
}

