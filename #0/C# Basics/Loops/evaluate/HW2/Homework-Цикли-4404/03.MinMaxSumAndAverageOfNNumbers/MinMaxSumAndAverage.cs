using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MinMaxSumAndAverageOfNNumbers
{
    class MinMaxSumAndAverage
    {
        static void Main(string[] args)
        {
            int NumbersCount = 0;
            bool LenghtBit = false;
            while (LenghtBit == false)
            {
                Console.WriteLine("Please enter the count of the numbers you gonna check: ");
                NumbersCount = int.Parse(Console.ReadLine());
                if (NumbersCount < 0)
                {
                    Console.WriteLine("The entered integer must be a positive number to meeting the program requrements!");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Now enter {0} numbers, using 'enter' after each one...", NumbersCount);
            List<int> Alfas = new List<int>();

            for (int i = 1; i <= NumbersCount; i++)
            {
                Alfas.Add(int.Parse(Console.ReadLine()));
            }
            int numMin = int.MaxValue;
            int numMax = int.MinValue;
            int sumOfAllNumbers = 0;
            foreach (var alfa in Alfas)
            {
                numMin = Math.Min(numMin, alfa);
                numMax = Math.Max(numMax, alfa);
                sumOfAllNumbers += alfa;
            }
            double averageNumbers = sumOfAllNumbers / 2.0;
            Console.WriteLine("Min = {0} ;", numMin);
            Console.WriteLine("Max = {0} ;", numMax);
            Console.WriteLine("Sum = {0} ;", sumOfAllNumbers);
            Console.WriteLine("Average = {0:f2} ;", averageNumbers);
        }
    }
}
