using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinLists
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(@"Program that takes as input two lists of integers and joins them. 
The result should hold all numbers from the first list, and all numbers from the second list, 
without repeating numbers, and arranged in increasing order. The input and output lists are given as integers, 
separated by a space, each list at a separate line.");
            Console.WriteLine("Give the first single line of integers, separeted by a space:");
            string firstLine = Console.ReadLine();
            Console.WriteLine("Give the second single line of integers, separeted by a space:");
            string secondLine = Console.ReadLine();
            string[] firstList = firstLine.Split(' ');
            List<int> first = new List<int> { };
            foreach (string word in firstList)
            {
                first.Add(int.Parse(word));
            }
            string[] secondList = secondLine.Split(' ');
            List<int> second = new List<int> { };
            foreach (string word in secondList)
            {
                second.Add(int.Parse(word));
            }
            List<int> newList = new List<int> { };
            foreach (int number in first)
            {
                if (!newList.Contains(number))
                {
                    newList.Add(number);
                }
            }
            foreach (int number in second)
            {
                if (!newList.Contains(number))
                {
                    newList.Add(number);
                }
            }
            newList.Sort();
            Console.Write("The new list is: ");
            foreach (int number in newList)
            {
                Console.Write(number + " ");
            }
        }
    }
}
