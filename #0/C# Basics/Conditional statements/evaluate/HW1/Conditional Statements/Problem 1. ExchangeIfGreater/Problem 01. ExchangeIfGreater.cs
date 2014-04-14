using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Problem_1.ExchangeIfGreater
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1: Write an if-statement that takes two integer variables a and b and exchanges 
            //their values if the first one is greater than the second one. 
            //As a result print the values a and b, separated by a space. 

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter first number: ");
            double firstNum = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double secondNum = double.Parse(Console.ReadLine());

            double testNum = 0;

            if (firstNum > secondNum)
            {
                testNum = firstNum;
                firstNum = secondNum;
                secondNum = testNum;
                Console.WriteLine(firstNum + " " + secondNum);
            }
            else
            {
                Console.WriteLine(firstNum + " " + secondNum);
            }
        }
    }
}
