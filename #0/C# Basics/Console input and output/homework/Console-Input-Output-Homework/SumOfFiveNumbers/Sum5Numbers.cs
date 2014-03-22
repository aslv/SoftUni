using System;

namespace SumOfFiveNumbers
{
    class Sum5Numbers
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += double.Parse(numbers[i]);
            }
            Console.WriteLine("The sum of the {0} numbers is {1}", numbers.Length, sum);
        }
    }
}
