using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Problem_5.The_BiggestOf3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 5: Write a program that finds the biggest of three numbers. -0.1	-0.5	-1.1	-0.1

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Please enter first number: ");
            double first = double.Parse(Console.ReadLine());

            Console.Write("Please enter second number: ");
            double second = double.Parse(Console.ReadLine());

            Console.Write("Please enter third number: ");
            double third = double.Parse(Console.ReadLine());

            double biggest;

            if (first > second)
            {
                if (first > third)
                {
                    biggest = first;
                }
                else
                {
                    biggest = third;
                }
            }
            else
            {
                if (second > third)
                {
                    biggest = second;
                }
                else
                {
                    biggest = third;
                }
            }

            Console.WriteLine(biggest);
        }
    }
}
