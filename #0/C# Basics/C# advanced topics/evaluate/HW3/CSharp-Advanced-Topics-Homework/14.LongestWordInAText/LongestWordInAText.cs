using System;

class LongestWordInAText
{
    static void Main()
    {
        /* 14. Write a program to find the longest word in a text. Examples:
         * 
         *              Input                        |     Output
         * Welcome to the Software University.       |   University
         * 
         * The C# Basics course is awesome start in  |   programming
         * programming with C# and Visual Studio.    |
         */

        Console.Write("Enter text: ");
        string text = Console.ReadLine();
        char[] split = new char[] { ' ', ',', '.', '-', '?', '!', '"' };
        string[] words = text.Split(split);
        string result = "";
        int maxLenght = 0;
        int lenght = 0;

        for (int i = 0; i < words.Length - 1; i++)
        {
            if (words[i].Length < words[i + 1].Length)
            {
                lenght = Convert.ToInt32(words[i + 1].Length);

                if (lenght > maxLenght)
                {
                    maxLenght = lenght;
                    result = words[i + 1];
                }
            }
        }

        Console.WriteLine(result);
    }
}