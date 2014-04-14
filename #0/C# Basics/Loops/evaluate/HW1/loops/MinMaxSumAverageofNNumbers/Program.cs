using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxSumAverageofNNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("numbers ?");
            int n = int.Parse(Console.ReadLine());
            double[] numbers = new double[n];
            for(int i =0; i<numbers.Length;i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("max {0:f2}", numbers.Max());
            Console.WriteLine("min {0:f2}", numbers.Min());
            Console.WriteLine("sum {0:f2}", numbers.Sum());
            Console.WriteLine("average {0:f2}",numbers.Average());
        }
    }
}
