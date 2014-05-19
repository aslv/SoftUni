using System;
using System.Collections.Generic;

class LongestNonDecreasingSubsequence
{
    static void Main()
    {
        /* 8. Write a program that reads a sequence of integers and finds in it the longest non-decreasing 
         * subsequence. In other words, you should remove a minimal number of numbers from the starting 
         * sequence, so that the resulting sequence is non-decreasing. In case of several longest non-decreasing
         * sequences, print the leftmost of them. The input and output should consist of a single line, holding
         * integer numbers separated by a space. Examples:
         * 
         * Input                               | Output
         * 1                                   | 1
         * 7 3 5 8 -1 6 7                      | 3 5 6 7
         * 1 1 1 2 2 2                         | 1 1 1
         * 1 1 1 3 3 3 2 2 2 2                 | 2 2 2 2
         * 11 12 13 3 14 4 15 5 6 7 8 7 16 9 8 | 3 4 5 6 7 8 9
         */

        //Console.Write("Eneter elements: ");
        //string input = Console.ReadLine();
        //string[] numbers = input.Split(' ');
        //int[] array = new int[numbers.Length];
        List<int> sequence = new List<int>();
        List<int> result = new List<int>();
        //
        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    array[i] = Convert.ToInt32(numbers[i]);
        //}

        List<int> opit = new List<int>() { 1, 2, 8, 0, 5, 6, 10, 12, 1, 7 };

    }
}