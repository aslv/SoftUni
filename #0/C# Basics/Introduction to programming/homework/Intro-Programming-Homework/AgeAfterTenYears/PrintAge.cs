using System;

namespace AgeAfterTenYears
{
    class PrintAge
    {
        static void Main()
        {
            Console.Write("Please enter your birthyear: ");
            int years = int.Parse(Console.ReadLine());
            Console.Write("Please enter your birthmonth: ");
            int months = int.Parse(Console.ReadLine());
            Console.Write("Please enter your birthday: ");
            int days = int.Parse(Console.ReadLine());
            DateTime birthTime = new DateTime(years, months, days);

            int yearsToAdd = 10;
            // we do not use straightforward DateTime.Now, because we are not interested in hours, minutes, etc.
            DateTime now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            // the most important action :)
            TimeSpan you = now - birthTime;

            /*
            Actually, this is not very correct, because we cannot unambiguously convert
            time period (the difference between two days) to period, including month and years.
            An example: 3 years may equals 1095 days or 1096 days.
            Of course, if we have two fixed dates, the period is exactly defined,
            but there is not such an integrated tool in .NET, so we can either calculate periods
            in dates (but in that case we cannot just add "10 years"), or to use approximate values.
            */
            DateTime yourAge = new DateTime(you.Ticks);

            Console.WriteLine("Now you are {0} years, {1} months amd {2} days old.",
                yourAge.Year - 1, yourAge.Month - 1, yourAge.Day - 1);

            yourAge = yourAge.AddYears(yearsToAdd);
            Console.WriteLine("After {3} years you will be {0} years, {1} months amd {2} days old.",
                yourAge.Year - 1, yourAge.Month - 1, yourAge.Day - 1, yearsToAdd);
        }
    }
}
