using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Problem_9.PlayWithIntDoubleString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 9: Write a program that, depending on the user’s choice, inputs an int, double or string variable. 
            //If the variable is int or double, the program increases it by one. 
            //If the variable is a string, the program appends "*" at the end. 
            //Print the result at the console. Use switch statement. 

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine(@"Please choose a type: 
            1 --> int
            2 --> double
            3 --> string");

            string userInput = Console.ReadLine();

            int intChoice = 0;
            double doubleChoice = 0;
            string stringChoice = "";

            switch (userInput)
            {
                case "1":
                    Console.Write("Please enter a int: ");
                    string userInt = Console.ReadLine();
                    if (int.TryParse(userInt, out intChoice))
                    {
                        intChoice += 1;
                        Console.WriteLine(intChoice);
                    }
                    else
	                {
                        Console.WriteLine("Invalid int!");
	                }
                    break;

                case "2":
                    Console.Write("Please enter a double: ");
                    string userDouble = Console.ReadLine();
                    if (double.TryParse(userDouble, out doubleChoice))
                    {
                        doubleChoice += 1;
                        Console.WriteLine(doubleChoice);
                    }
                    else
	                {
                        Console.WriteLine("Invalid double!");
	                }
                    break;

                case "3":
                    Console.Write("Please enter a string: ");
                    stringChoice = Console.ReadLine();
                    stringChoice += '*';
                    Console.WriteLine(stringChoice);
                    break;

                default:
                    Console.WriteLine("It is not valid choice! Try again!");
                    break;
            }
        }
    }
}
