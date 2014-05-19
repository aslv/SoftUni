using System;
using System.Collections.Generic;

class JoinLists
{
    static void Main()
    {
        /* 10. Write a program that takes as input two lists of integers and joins them. The result should hold
         * all numbers from the first list, and all numbers from the second list, without repeating numbers, and
         * arranged in increasing order. The input and output lists are given as integers, separated by a space,
         * each list at a separate line. Examples:
         * 
         * Input                Output
         * 20 40 10 10 30 80    10 20 25 30 40 80
         * 25 20 40 30 10
         * 
         * 5 4 3 2 1            1 2 3 4 5 6
         * 6 3 2
         * 
         * 1                    1
         * 1
         */

        Console.Write("Enter first sequence: ");
        string first = Console.ReadLine();
        
        Console.Write("Enter second sequence: ");
        string second = Console.ReadLine();
        //string first = "20 40 10 10 30 80";
        //string second = "25 20 40 30 10 80 80 80";
        string all = first + " " + second;
        string[] allNumbers = all.Split(' ');
        List<int> result = new List<int>();
        List<int> numbers = new List<int>();

        for (int i = 0; i < allNumbers.Length; i++)
        {
            numbers.Add(Convert.ToInt32(allNumbers[i]));
        }

        numbers.Sort();

        for (int i = 0; i < numbers.Count - 1; i++)
        {
            if (numbers[i] < numbers[i + 1])
            {
                result.Add(numbers[i]);
            }
        
            if (i == numbers.Count - 2)
            {
                if (numbers[i] <= numbers[i + 1])
                {
                    result.Add(numbers[i + 1]);
                }
            }
        }

        foreach (int item in result)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
    }
}