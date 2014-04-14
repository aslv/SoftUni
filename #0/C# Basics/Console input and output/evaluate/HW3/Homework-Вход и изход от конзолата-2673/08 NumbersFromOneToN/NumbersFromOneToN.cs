using System;

class NumbersFromOneToN
{
    static void Main()
    {
        Console.Write("Please enter an integer n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

