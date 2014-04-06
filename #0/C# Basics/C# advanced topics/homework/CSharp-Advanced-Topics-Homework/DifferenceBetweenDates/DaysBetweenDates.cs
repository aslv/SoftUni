using System;
using System.Globalization;

namespace DifferenceBetweenDates
{
    class DaysBetweenDates
    {
        static void Main()
        {
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", new CultureInfo("en-US"));
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", new CultureInfo("en-US"));
            Console.WriteLine((secondDate - firstDate).Days);
        }
    }
}
