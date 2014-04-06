using System;

namespace Problem_1.Odd_or_Even_Integers
{
    class OddOrEvenIntegers
    {
        static void Main()
        {
            Console.Write("Enter an integer number:");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("{0} is even.", number);
            }
            else
            {
                Console.WriteLine("{0} is odd.", number);
            }
        }
    }
}
