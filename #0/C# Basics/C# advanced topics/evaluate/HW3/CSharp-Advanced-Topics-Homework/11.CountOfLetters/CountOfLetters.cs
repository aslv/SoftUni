using System;
using System.Collections.Generic;

class CountOfLetters
{
    static void Main()
    {
        /* 11. Write a program that reads a list of letters and prints for each letter how many times it appears
         * in the list. The letters should be listed in alphabetical order. Use the input and output format from
         * the examples below. Examples:
         * 
         * Input                               | Output
         * b b a a b                           | a -> 2
         *                                     | b -> 3
         * 
         * h d h a a a s d f d a d j d s h a a | a -> 6
         *                                     | d -> 5
         *                                     | f -> 1
         *                                     | h -> 3
         *                                     | j -> 1
         *                                     | s -> 2
         */

        string input = Console.ReadLine();
        //string input = "h d h a a a s d f d a d j d s h a a";
        string[] letter = input.Split(' ');
        string ch = "";
        int count = 1;

        Array.Sort(letter);

        Console.WriteLine("Variant 1:");

        for (int i = 0; i < letter.Length - 1; i++)
        {
            ch = letter[i];
        
            if (letter[i] == letter[i + 1])
            {
                count++;
            }
            else
            {
                Console.WriteLine("{0} -> {1}", ch, count);
                count = 1;
                continue;
            }
        }
        
        Console.WriteLine("{0} -> {1}", ch, count);
        Console.WriteLine(new string('-', 26));
        
        Console.WriteLine("Variant 2:");

        Dictionary<string, int> result = new Dictionary<string, int>();

        for (int i = 0; i < letter.Length; i++)
        {
            if (result.ContainsKey(letter[i]))
            {
                count++;
                result[letter[i]] = count;
            }
            else
            {
                count = 1;
                result.Add(letter[i], count);
            }
        }

        foreach (var item in result)
        {
            Console.WriteLine("{0} -> {1}", item.Key, item.Value);
        }
    }
}