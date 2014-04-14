using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageLoadTimeCalculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(@"We have a report that holds dates, web site URLs and load times (in seconds). 
This program calculates the average load time for each URL.");
            Console.WriteLine("Write line:");
            string line = Console.ReadLine();
            Dictionary<string, double> dict = new Dictionary<string, double> { };
            while (line != string.Empty)
            {
                string[] list = line.Split(' ');
                string link = list[2];
                double loadTime = double.Parse(list[3]);
                if (!dict.Keys.Contains(link))
                {
                    dict[link] = loadTime;
                }
                else
                {
                    dict[link] = (dict[link] + loadTime) / 2;
                }
                Console.WriteLine("Write line:");
                line = Console.ReadLine();
            }
            foreach (string link in dict.Keys)
            {
                Console.WriteLine(link + " --> " + dict[link]);
            }
        }
    }
}
