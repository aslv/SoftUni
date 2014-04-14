using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("please enter value for n: ");
        int n = int.Parse(Console.ReadLine());
        int result = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Please enter value {0}: ", i + 1);
            int number = int.Parse(Console.ReadLine());
            result = number + result;
        }
        Console.WriteLine("The sum of all numbers entered is: {0}", result);
    }
}

