using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DifferenceBetweenDates
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Program that enters two dates in format dd.MM.yyyy and returns the number of days between them.");
            Console.WriteLine("Enter first date: ");
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter second date: ");
            DateTime secondDate = DateTime.Parse(Console.ReadLine());
            TimeSpan difference = secondDate - firstDate;
            Console.WriteLine("The number of day between {0} and {1} is {2} days.", firstDate, secondDate, difference.Days);
        }
    }
}
