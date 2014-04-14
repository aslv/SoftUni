using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNames
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(@"Program that takes as input two lists of names and removes from the first list all names given in 
the second list. The input and output lists are given as words, separated by a space, each list at a separate line.");
            Console.WriteLine("Give the first single line of names, separeted by a space:");
            string firstLine = Console.ReadLine();
            Console.WriteLine("Give the second single line of names, separeted by a space:");
            string secondLine = Console.ReadLine();
            string[] firstList = firstLine.Split(' ');
            string[] secondList = secondLine.Split(' ');
            string[] newList = new string[firstList.Length];
            int i = 0;
            foreach (string word in firstList)
            {
                if (!secondList.Contains(word))
                {
                    newList.SetValue(word, i);
                    i++;
                }
            }
            Console.Write("The new list is: ");
            foreach (string word in newList)
            {
                Console.Write(word + " ");
            }
        }
    }
}
