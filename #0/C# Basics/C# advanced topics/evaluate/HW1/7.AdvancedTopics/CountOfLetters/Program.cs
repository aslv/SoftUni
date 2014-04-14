using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfLetters
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(@"Program that reads a list of letters and prints for each letter how many times 
it appears in the list. The letters should be listed in alphabetical order.");
            Console.WriteLine("Write list of letters:");
            string line = Console.ReadLine();
            string[] list = line.Split(' ');
            List<string> nonDuplicate = new List<string> { };
            foreach (string letter in list)
            {
                if (!nonDuplicate.Contains(letter))
                {
                    nonDuplicate.Add(letter);
                }
            }
            nonDuplicate.Sort();
            Dictionary<string, int> dict = new Dictionary<string, int> { };
            foreach (string letter in nonDuplicate)
            {
                dict[letter] = 0;
            }
            foreach (string letter in list)
            {
                dict[letter]++;
            }
            foreach (string letter in dict.Keys)
            {
                Console.WriteLine(letter+" --> "+dict[letter]);
            }
        }
    }
}
