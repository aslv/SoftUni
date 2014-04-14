using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.BeerTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 10: A beer time is after 1:00 PM and before 3:00 AM. Write a program that enters a time 
            //in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) 
            //and prints “beer time” or “non-beer time” according to the definition above or “invalid time”
            //if the time cannot be parsed. Note that you may need to learn how to parse dates and times. 

            //string windowsPanelTime = "8:04 PM";
            //DateTime time = DateTime.Parse(windowsPanelTime);
            //Console.WriteLine(time);

            DateTime startBeerTime = DateTime.Parse("1:00 PM");
            DateTime endOfBeerTime = DateTime.Parse("3:00 AM");
            endOfBeerTime = endOfBeerTime.AddDays(1);
            Console.Write(@"Please enter a time in format ""hh:mm tt"" 
            (an hour in range [01...12], a minute in range [00…59] and AM / PM designator): ");

            DateTime beginOfNight = DateTime.Parse("12:00 AM");
            DateTime endOfNight = DateTime.Parse("02:59 AM");

            string userInput = Console.ReadLine();
            DateTime userChoice;

            if (DateTime.TryParse(userInput, out userChoice))
            {
                if (userChoice >= beginOfNight && userChoice <= endOfNight)
                {
                    userChoice = userChoice.AddDays(1);
                }

                if (userChoice >= startBeerTime && userChoice < endOfBeerTime)
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
                Console.WriteLine("Invalid time!");
            }
        }
    }
}
