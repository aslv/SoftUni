using System;
using System.Text.RegularExpressions;

    class CountingAWordInAText
    {
        static void Main()
        {
            /* 16. Write a program that counts how many times a given word occurs in given text. The first line
             * in the input holds the word. The second line of the input holds the text. The output should be a 
             * single integer number – the number of word occurrences. Matching should be case-insensitive. Note
             * that not all matching substrings are words and should be counted. A word is a sequence of letters
             * separated by punctuation or start / end of text. Examples:
             * 
             *                  Input                                                 | Output
             * hi                                                                     |     3
             * Hidden networks say “Hi” only to Hitachi devices. Hi, said Matuhi. HI! |
             * 
             *      Input           |  Output
             * SoftUni              |     0
             * Software University  |
             *                      
             * SoftUni              |     1
             * SoftUni              |
             *                      
             * SoftUni              |     2
             * SoftUni.SoftUni      |
             */

            //string search = "hi";
            //string search = @"(\bhi\b)"; //Use with Regex - test with text below.
            //string input = "Hidden networks say “Hi” only to Hitachi devices. Hi, said Matuhi. HI!";

            //string search = "softuni";
            //string search = @"(\bsoftuni\b)"; //Use with regex - test with text below.
            //string input = "The Software University (SoftUni) trains software engineers, gives them a profession and a job. Visit us at http://softuni.bg. Enjoy the SoftUnification at SoftUni.BG. Contact us.Email: INFO@SOFTUNI.BG. Facebook: https://www.facebook.com/SoftwareUniversity. YouTube: http://www.youtube.com/SoftwareUniversity. Google+: https://plus.google.com/+SoftuniBg/. Twitter: https://twitter.com/softunibg. GitHub: https://github.com/softuni";

            Console.Write("Enter word: ");
            //string search = Console.ReadLine();
            string search = @"(\b" + Console.ReadLine() + @"\b)"; //Use with regex

            Console.Write("Enter text: ");
            string input = Console.ReadLine();

            //char[] splitChar = { ' ', '.', ',', '(', ')', '?', '!', '-', '"', '@', '#',
            //                     '$', '%', '^', '&', '*', '/', '\\', '+', '_', '`', '~',
            //                     ':', ';', '[', ']', '{', '}', '|', '“', '”'};
            //string[] data = input.ToUpper().Split(splitChar, StringSplitOptions.RemoveEmptyEntries);
            //int count = 0;
            //
            //for (int i = 0; i < data.Length; i++)
            //{
            //    if (data[i].Contains(search.ToUpper()))
            //    {
            //        //Console.WriteLine(data[i]);
            //
            //        if (data[i].Length > search.Length)
            //        {
            //            continue;
            //        }
            //        count++;
            //    }
            //}

            //Regex (regular expression/s) - more information: Google, MSDN
            Regex regex = new Regex(search, RegexOptions.IgnoreCase); 
            int count = regex.Matches(input).Count;

            Console.WriteLine(count);   
        }
    }