using System;
using System.Globalization;

namespace BeerTime
{
    class Beer
    {
        static void Main()
        {
            DateTime morning = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 3, 0, 0);
            DateTime afternoon = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 13, 0, 0);
            DateTime current;
            if (DateTime.TryParseExact(Console.ReadLine(), "h:mm tt", new CultureInfo("en-US"), DateTimeStyles.None, out current))
            {
                if (current < morning || current >= afternoon)
                {
                    Console.WriteLine("beer time");
                }
                else
                {
                    Console.WriteLine("non-beer time");
                }
            }
            else
            {
                Console.WriteLine("invalid time");
            }
        }
    }
}
