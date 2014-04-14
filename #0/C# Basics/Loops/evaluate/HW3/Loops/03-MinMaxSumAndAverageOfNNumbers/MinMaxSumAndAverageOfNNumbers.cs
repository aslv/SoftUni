using System;
using System.Collections.Generic;

    class MinMaxSumAndAverageOfNNumbers
    {
        static void Main()
        {
            string inputStr = Console.ReadLine();
            int countN = int.Parse(inputStr);
            if (countN < 1)
            {
                Console.WriteLine("Error - Invalid Number ");
            }
            else
            {
                List<int> numbers = new List<int>(countN);
                for (int i = 0; i < countN; i++)
                {
                    Console.Write("Enter the next whole number of sequence: ");
                    inputStr = Console.ReadLine();
                    numbers.Add(int.Parse(inputStr));
                }
                int numMin = int.MaxValue;
                int numMax = int.MinValue;
                int sumOfAllNumbers = 0;
                foreach (var number in numbers)
                {
                    numMin = Math.Min(numMin, number);
                    numMax = Math.Max(numMax, number);
                    sumOfAllNumbers += number;
                }
                double averageNumbers = sumOfAllNumbers / 2.0;
                Console.WriteLine("Min = {0} and Max = {1} ", numMin, numMax);
                Console.WriteLine("Sum = {0} and Average = {1:F2} ", sumOfAllNumbers, averageNumbers);
            }
            Console.ReadLine();
        }
    }

