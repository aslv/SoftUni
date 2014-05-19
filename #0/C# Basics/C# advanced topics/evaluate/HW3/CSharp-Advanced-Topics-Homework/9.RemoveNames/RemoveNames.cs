using System;
using System.Collections.Generic;

class RemoveNames
{
    static void Main()
    {
        /* 9. Write a program that takes as input two lists of names and removes from the first list all names
         * given in the second list. The input and output lists are given as words, separated by a space, each 
         * list at a separate line. Examples:
         * 
         * Input                                      |  Output
         * Peter Alex Maria Todor Steve Diana Steve   |  Peter Alex Maria Diana
         * Todor Steve Nakov                          |
         * 
         * Input                             |   Output
         * Hristo Hristo Nakov Nakov Petya   |   Hristo Hristo Petya
         * Nakov Vanessa Maria               |
         */

        Console.Write("Enter first list: ");
        string first = Console.ReadLine();
        
        Console.Write("Enter second list: ");
        string second = Console.ReadLine();
        //string first = "Peter Alex Maria Todor Steve Diana Steve";
        //string second = "Todor Steve Nakov";
        string[] allNames = first.Split(' ');
        string[] namesToRemove = second.Split(' ');
        List<string> result = new List<string>();

        for (int i = 0; i < allNames.Length; i++)
        {
            result.Add(allNames[i]);
        }

        for (int i = 0; i < namesToRemove.Length; i++)
        {
            for (int j = 1; j < result.Count; j++)
            {
                result.Remove(namesToRemove[i]);
            }
        }

        foreach (string name in result)
        {
            Console.Write(name + " ");
        }
        Console.WriteLine();
    }
}