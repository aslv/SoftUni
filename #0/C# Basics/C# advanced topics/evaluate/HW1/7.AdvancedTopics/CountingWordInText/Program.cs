using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingWordInText
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Program that counts how many times a given word occurs in given text.");
            Console.WriteLine("Give a word:");
            string givenWord = Console.ReadLine();
            Console.WriteLine("Give a text:");
            string text = Console.ReadLine();
            foreach (char c in text)
            {
                if (!((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z')))
                {
                    text = text.Replace(c, ' ');
                }
            }
            string[] list = text.Split(' ');
            int counter = 0;
            foreach (string word in list)
            {
                if (word.ToLower() == givenWord.ToLower())
                {
                    counter++;
                }
            }
            Console.WriteLine("The given word {0} occurs {1} times in the given text.", givenWord, counter);
        }
    }
}