using System;
using System.Collections.Generic;

class CountOfNames
{
    static void Main()
    {
        /* 12. Write a program that reads a list of names and prints for each name how many times it appears in
         * the list. The names should be listed in alphabetical order. Use the input and output format from the 
         * examples below. Examples:
         * 
         *              Input                 |  Output
         * Peter Steve Nakov Steve Alex Nakov | Alex -> 1
         *                                    | Nakov -> 2
         *                                    | Peter -> 1
         *                                    | Steve -> 2
         *                                              
         * Nakov Nakov Nakov SoftUni Nakov    |  SoftUni ->
         *                                    |  Nakov -> 5
         */

        string input = Console.ReadLine();
        //string input = "Peter Steve Nakov Steve Alex Nakov";
        string[] names = input.Split(' ');
        Dictionary<string, int> times = new Dictionary<string,int>();
        
        Array.Sort(names);

        int count = 1;  

        for (int i = 0; i < names.Length; i++)
        {
            if (times.ContainsKey(names[i]))
            {
                count++;
                times[names[i]] = count;
            }
            else
            {
                count = 1;
                times.Add(names[i], count);
            }
        }

        foreach (var item in times)
        {
            Console.WriteLine("{0} -> {1}", item.Key, item.Value);
        }
    }
}