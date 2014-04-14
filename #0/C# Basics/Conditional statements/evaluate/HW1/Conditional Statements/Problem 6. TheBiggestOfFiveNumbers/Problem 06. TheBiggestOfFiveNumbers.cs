using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Problem_6.TheBiggestOfFiveNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 6: Write a program that finds the biggest of five numbers by using only five if statements. 

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Please enter first number: ");
            double first = double.Parse(Console.ReadLine());

            Console.Write("Please enter second number: ");
            double second = double.Parse(Console.ReadLine());

            Console.Write("Please enter third number: ");
            double third = double.Parse(Console.ReadLine());

            Console.Write("Please enter forth number: ");
            double forth = double.Parse(Console.ReadLine());

            Console.Write("Please enter fifth number: ");
            double fifth = double.Parse(Console.ReadLine());

            double biggest = first;

            if (first >= second && first >= third && first >= forth && first >= fifth)
            {
                biggest = first;
            }
            else if (second >= first && second >= third && second >= forth && second >= fifth)
            {
                biggest = second;
            }
            else if (third >= first && third >= second && third >= forth && third >= fifth)
            {
                biggest = third;
            }
            else if (forth >= first && forth >= second && forth >= third && forth >= fifth)
            {
                biggest = forth;
            }
            else if (fifth >= first && fifth >= second && fifth >= third && fifth >= forth)
            {
                biggest = fifth;
            }

            Console.WriteLine(biggest);
        }
    }
}
