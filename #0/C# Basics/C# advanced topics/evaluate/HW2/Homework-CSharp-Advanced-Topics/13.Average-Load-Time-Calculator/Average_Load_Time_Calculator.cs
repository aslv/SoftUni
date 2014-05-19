using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class AverageLoadTimeCalculator
{
    static void Main(string[] args)
    {
        string line = Console.ReadLine();
        Dictionary<string, double> sumOfTime = new Dictionary<string, double>();
        Dictionary<string, int> countOfLoads = new Dictionary<string, int>();

        while (line != string.Empty)
        {
            string[] list = line.Split(' ');
            string link = list[2];
            double loadTime = double.Parse(list[3], CultureInfo.InvariantCulture);
            if (!sumOfTime.Keys.Contains(link))
            {
                sumOfTime[link] = loadTime;
                countOfLoads[link] = 1;
            }
            else
            {
                sumOfTime[link] = sumOfTime[link] + loadTime;
                countOfLoads[link]++;
            }
            line = Console.ReadLine();
        }

        foreach (string link in sumOfTime.Keys)
        {
            Console.WriteLine(link + " --> " + sumOfTime[link] / countOfLoads[link]);
        }
    }
}