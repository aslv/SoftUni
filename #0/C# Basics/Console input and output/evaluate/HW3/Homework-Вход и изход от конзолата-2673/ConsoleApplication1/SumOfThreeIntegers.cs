using System;

class SumOfThreeIntegers
{
    static void Main()
    {

        int a;
        int b;
        int c;

        do
        {
            Console.Write("Please enter first integer a: ");
        } while (!int.TryParse(Console.ReadLine(), out a));

        do
        {
            Console.Write("Please enter second integer b: ");
        } while (!int.TryParse(Console.ReadLine(), out b));

        do
        {
            Console.Write("Please enter third integer c: ");
        } while (!int.TryParse(Console.ReadLine(), out c));


        int sum = a + b + c;
        Console.WriteLine("The sum of the three integers is: {0}", sum);
    }
}

