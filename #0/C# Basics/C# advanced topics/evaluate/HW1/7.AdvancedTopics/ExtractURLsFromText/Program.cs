using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractURLsFromText
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Program that extracts and prints all URLs from given text.");
            Console.Write("Write text:");
            string line = Console.ReadLine();
            string[] list = line.Split(' ');
            List<string> newList = new List<string>{ };
            foreach (string word in list)
            {
                if (!newList.Contains(word) && word.Length>6)
                {
                    if (word.Substring(0, 7)=="http://" || word.Substring(0, 4)=="www.")
                    {
                        newList.Add(word);
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("The hyperlinks in the text are:");
            foreach (string word in newList)
            {
                Console.WriteLine(word);
            }
        }
    }
}
