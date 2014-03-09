using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    class AstrologicalDigits
    {
        static void Main()
        {
            string number = Console.ReadLine();
            int sum = 0;
            foreach (char digit in number)
            {
                if (digit != '-' && digit != '.')
                {
                    sum += int.Parse(digit.ToString());
                }
            }

            Console.WriteLine(Sum(sum));
        }

        private static int Sum(int sum)
        {
            if (sum < 10)
            {
                return sum;
            }
            int current = 0;
            while (sum > 0)
            {
                current += sum % 10;
                sum /= 10;
            }
            return Sum(current);
        }
    }
}
