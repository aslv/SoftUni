using System;

class SumOfNNumbers
{
    static void Main(string[] args)
    {
        int sum = 0;
        Console.WriteLine("Enter a number n: ");
        int number = int.Parse(Console.ReadLine());
        for (int i = 0; i < number; i++)
        {
            int num = int.Parse(Console.ReadLine());
            sum = sum + num;
        }
        Console.WriteLine("The sum is: {0}.", sum);
    }
}
