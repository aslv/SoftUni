using System;
using System.Collections.Generic;

namespace CountingAWordInAText
{
    class CountingWord
    {
        static void Main()
        {
            string theWord = Console.ReadLine();
            string text = Console.ReadLine();
            char[] delims = new char[] { '\0', '\t', ' ', '\n', '\r', '!', '"', '#', '$', '%', '^', '&', '\'', '*', '(', ')', '+', ',', '-', '.', '/', ':', ';', '<', '=', '>', '?', '@', '_', '`', '[', ']', '{', '}', '|', '\\', '~' };
            string[] words = text.Split(delims, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            foreach (string word in words)
            {
                if (word.Equals(theWord, StringComparison.InvariantCultureIgnoreCase))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
