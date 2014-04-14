using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Problem_7.Sort3NumbersWithNestedIfs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 7: Write a program that enters 3 real numbers and prints them sorted in descending order. 
            //Use nested if statements. Don’t use arrays and the built-in sorting functionality. 

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Please enter first number: ");
            double firstNum = double.Parse(Console.ReadLine());

            Console.Write("Please enter second number: ");
            double secondNum = double.Parse(Console.ReadLine());

            Console.Write("Please enter third number: ");
            double thirdNum = double.Parse(Console.ReadLine());

            double firstPosition = firstNum;
            double secondPosition = secondNum;
            double thirdPosition = thirdNum;

            if (firstNum >= secondNum && firstNum >= thirdNum)
            {
                firstPosition = firstNum;

                if (secondNum >= thirdNum)
                {
                    secondPosition = secondNum;
                    thirdPosition = thirdNum;
                }
                else
                {
                    secondPosition = thirdNum;
                    thirdPosition = secondNum;
                }
            }
            else if (secondNum >= thirdNum)
            {
                firstPosition = secondNum;

                if (firstNum >= thirdNum)
                {
                    secondPosition = firstNum;
                    thirdPosition = thirdNum;
                }
                else
                {
                    secondPosition = thirdNum;
                    thirdPosition = firstNum;
                }
            }
            else
            {
                firstPosition = thirdNum;

                if (firstNum >= secondNum)
                {
                    secondPosition = firstNum;
                    thirdPosition = secondNum;
                }
                else
                {
                    secondPosition = secondNum;
                    thirdPosition = firstNum;
                }
            }

            Console.WriteLine("{0} {1} {2}", firstPosition, secondPosition, thirdPosition);
        }
    }
}
