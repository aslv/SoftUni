using System;

namespace LongestWordInAText
{
    class LongestWord
    {
        static void Main()
        {
            string text = "";
            // text = Console.In.ReadToEnd(); // UNCOMMENT THIS AND COMMENT NEXT LINES IF YOU WANT TO FOLLOW EXACTLY THE TASK
            string line;
            while ((line = Console.ReadLine()) != "")
            {
                text += line;
            }
            char[] delims = new char[] { '\0', '\t', ' ', '\n', '\r', '!', '"', '#', '$', '%', '^', '&', '\'', '*', '(', ')', '+', ',', '-', '.', '/', ':', ';', '<', '=', '>', '?', '@', '_', '`', '[', ']', '{', '}', '|', '\\', '~' };
            string[] words = text.Split(delims, StringSplitOptions.RemoveEmptyEntries);
            int maxLen = 0;
            string maxWord = "";
            foreach (string word in words)
            {
                if (word.Length > maxLen)
                {
                    maxLen = word.Length;
                    maxWord = word;
                }
            }
            Console.WriteLine(maxWord);
        }
    }
}