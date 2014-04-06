using System;

namespace MinMaxSumAndAverageOfNNumbers
{
    class MinMaxSumAvg
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.MaxValue, max = int.MinValue, sum = 0, current;
            double avg;
            for (int i = 0; i < n; i++)
            {
                current = int.Parse(Console.ReadLine());
                if (current < min)
                {
                    min = current;
                }
                if (current > max)
                {
                    max = current;
                }
                sum += current;
            }
            avg = (double)sum / n;
            Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3:f2}", min, max, sum, avg);
        }
    }
}
