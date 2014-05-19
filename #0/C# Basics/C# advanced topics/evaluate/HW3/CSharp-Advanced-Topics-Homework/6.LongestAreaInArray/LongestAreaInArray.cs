using System;

class LongestAreaInArray
{
    static void Main()
    {
        /* 6. Write a program to find the longest area of equal elements in array of strings. You first should 
         * read an integer n and n strings (each at a separate line), then find and print the longest sequence 
         * of equal elements (first its length, then its elements). If multiple sequences have the same maximal 
         * length, print the leftmost of them. Examples:
         * 
         * Input | Output     Input   | Output     Input | Output     Input | Output
         * 6     | 3          2       | 1          4     | 4          5     | 2
         * hi    | ok         SoftUni | SoftUni    hi    | hi         wow   | hi
         * hi    | ok         Hello   |            hi    | hi         hi    | hi
         * hello | ok                              hi    | hi         hi    | 
         * ok    |                                 hi    | hi         ok    | 
         * ok    |                                                    ok    | 
         * ok    | 
         */

        Console.Write("Enter n = ");
        int n = int.Parse(Console.ReadLine());
        string[] text = new string[n];
        string repeatinString = "";
        int count = 1;
        int countRepeat = 1;
                
        for (int i = 0; i < text.Length; i++)
        {
            Console.Write("Enter string: ");
            text[i] = Console.ReadLine();
        }

        for (int i = 0; i < text.Length - 1; i++)
        {
            if (text[i].Length == text[i + 1].Length)
            {
                string firstText = text[i];
                string secondText = text[i + 1];
                bool equal = false;
                
                for (int j = 0; j < text[i].Length; j++)
                {
                    if (firstText[j] == secondText[j])
                    {
                        equal = true;
                    }
                    else
                    {
                        count = 1;
                        equal = false;
                        break;
                    }
                }

                if (equal)
                {
                    count++;
                   
                    if (count > countRepeat)
                    {
                        countRepeat++;
                        repeatinString = firstText;
                    }
                }
            }
            else if (text[i].Length > text[i + 1].Length)
            {
                repeatinString = text[i];
                count = 1;
            }
            else
            {
                repeatinString = text[i + 1];
                count = 1;
            }
        }
        
        Console.WriteLine(count);

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(repeatinString);
        }
    }
}