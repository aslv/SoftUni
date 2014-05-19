using System;

class DifferenceBetweenDates
{
    static void Main()
    {
        /* 4. Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between
         * them.
         * Examples:
         * 
         * First date   Second date     Days between
         * 17.03.2014   30.04.2014          44
         * 17.03.2014   17.03.2014           0
         * 14.06.1980    5.03.2014         12317
         *  5.03.2014    3.03.2014          -2
         */

        Console.WriteLine("Enter two dates in format d.MM.yyyy: ");
        Console.Write("First date: ");
        string first = Console.ReadLine();
        DateTime firstDate = DateTime.Parse(first);

        Console.Write("Second date: ");
        string second = Console.ReadLine();

        DateTime secondDate = DateTime.Parse(second);

        TimeSpan daysBetween = secondDate - firstDate;

        Console.WriteLine(new string('-', 52));
        Console.WriteLine("Days between {0:d.MM.yyyy} and {1:d.MM.yyyy} is: {2}", firstDate, secondDate, daysBetween.Days);
    }
}