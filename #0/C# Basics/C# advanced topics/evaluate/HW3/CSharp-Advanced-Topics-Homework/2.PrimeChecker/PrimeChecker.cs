using System;

class PrimeChecker
{
    static void Main()
    {
        /* 2. Write a Boolean method IsPrime(n) that check whether a given integer number n is prime.
         * Examples:
         * 
         *       n      | IsPrime(n)
         *            0 | false
         *            1 | false
         *            2 | true
         *            3 | true
         *            4 | false
         *            5 | true
         *          323 | false
         *          337 | true
         *   6737626471 | true
         * 117342557809 | false
         */

        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine("Number must be positive!!");
        }
        else
        {
            Console.WriteLine("{0} is prime?: {1}", number, IsPrime(number));
        }
    }

    static bool IsPrime(int number)
    {
        int deviders = 0;

        for (int i = 2; i <= number; i++)
        {
            if (number % i == 0)
            {
                deviders++;
            }
        }

        return deviders == 1 ? true : false;
    }
}