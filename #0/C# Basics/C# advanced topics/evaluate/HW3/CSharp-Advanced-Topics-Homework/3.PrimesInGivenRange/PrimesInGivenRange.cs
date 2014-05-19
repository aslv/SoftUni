using System;
using System.Collections.Generic;

class PrimesInGivenRange
{
    static void Main()
    {
        /* 3. Write a method that calculates all prime numbers in given range and returns them as list of 
         * integers. Write a method to print a list of integers. Write a program that enters two integer numbers
         * (each at a separate line) and prints all primes in their range, separated by a comma.
         * Examples:
         * 
         * Start number|End number|  Output
         *      0      |    10    |2, 3, 5, 7
         *      5      |    11    | 5, 7, 11
         *     100     |    50    |(empty list)
         */

        Console.WriteLine("Primes in given range");
        Console.Write("Enter start number: ");
        int startNum = int.Parse(Console.ReadLine());

        Console.Write("Enter end number: ");
        int endNum = int.Parse(Console.ReadLine());

        if (startNum < 0 || endNum < 0)
        {
            Console.WriteLine("One of numbers or both are negative!!");
        }
        else if (startNum > endNum)
        {
            Console.WriteLine("empty List");
        }
        else
        {
            PrintList(FindPrimesInRange(startNum, endNum));
        }
    }

    static List<int> FindPrimesInRange(int startNumber, int endNumber)
    {
        List<int> numbers = new List<int>();

        for (int i = startNumber; i <= endNumber; i++)
        {
            
            int deviders = 0;
            int number = i;

            for (int j = 2; j <= number; j++)
            {
                if (number % j == 0)
                {
                    deviders++;
                }
            }

            if (deviders == 1)
            {
                numbers.Add(number);
            }
        }

        return numbers;
    }

    static void PrintList(List<int> FindPrimesInRange)
    {
        for (int i = 0; i < FindPrimesInRange.Count; i++)
        {
            if (i < FindPrimesInRange.Count - 1)
            {
                Console.Write(FindPrimesInRange[i] + ", ");
            }
            else
            {
                Console.Write(FindPrimesInRange[i]);
            }
        }

        Console.WriteLine();
    }
}