using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Problem_4.MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 4: Write a program that shows the sign (+, - or 0) 
            //of the product of three real numbers, without calculating it. 
            //Use a sequence of if operators. 

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Please enter first real number: ");
            double first = double.Parse(Console.ReadLine());

            Console.Write("Please enter second real number: ");
            double second = double.Parse(Console.ReadLine());

            Console.Write("Please enter third real number: ");
            double third = double.Parse(Console.ReadLine());

            if (first == 0 || second == 0 || third == 0)
            {
                Console.WriteLine("0");
            }
            else if ((first > 0) ^ (second > 0) ^ (third > 0)) //The ^ operator behaves like multiplication; 
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
        }
    }
}
