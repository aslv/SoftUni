﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Longest_Word_In_A_Text
{
    static void Main()
    {
        string someText = Console.ReadLine();
        string[] allWords = someText.Split(new char[] { ' ', ',', ':', ';', '.' },
                                                StringSplitOptions.RemoveEmptyEntries);

        int longestWordIndex = 0;
        for (int i = 1; i < allWords.Length; i++)
        {
            if (allWords[i].Length > allWords[longestWordIndex].Length)
            {
                longestWordIndex = i;
            }
        }

        Console.WriteLine(allWords[longestWordIndex]);
    }
}