using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.NumberAsWords
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 11: Write a program that converts a number in the range [0…999] to words, 
            //corresponding to the English pronunciation. 

            string[] numbersFrom0to20 = {"zero", "one", "two", "tree", "four", "five", "six", "seven", "eight", "nine", "ten",
                                        "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eightteen",
                                        "nineteen"}; 

            string[] numbersFrom20to90 = {"","ten","twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"};

            Console.Write("Please enter a number in range [0...999]: ");
            int userInput = int.Parse(Console.ReadLine());

            int ones;
            int tens;
            int hundreds;

            if (userInput >= 0 && userInput < 20)
            {
                Console.WriteLine(numbersFrom0to20[userInput]);
            }
            else if (userInput >= 20 && userInput <= 99)
            {
                ones = userInput % 10;
                tens = userInput / 10;

                if (ones == 0)
                {
                    Console.WriteLine("{0}", numbersFrom20to90[tens]);
                }
                else
                {
                    Console.WriteLine("{0} {1}", numbersFrom20to90[tens], numbersFrom0to20[ones]);
                }
                
            }
            else if (userInput >= 100 && userInput <= 999)
            {
                ones = userInput % 10;
                tens = (userInput / 10) % 10;
                hundreds = userInput / 100;

                if (tens == 0 && ones > 0)
                {
                    Console.WriteLine("{0} hundred and {1}", numbersFrom0to20[hundreds], numbersFrom0to20[ones]);
                }
                else if (ones == 0 && tens > 0)
                {
                    Console.WriteLine("{0} hundred and {1}", numbersFrom0to20[hundreds], numbersFrom20to90[tens]);
                }
                else if (tens == 0 && ones == 0)
                {
                    Console.WriteLine("{0} hundred", numbersFrom0to20[hundreds]);
                }
                else if (tens == 1)
                {
                    Console.WriteLine("{0} hundred and {1}", numbersFrom0to20[hundreds], numbersFrom0to20[10 + ones]);
                }
                else
                {
                    Console.WriteLine("{0} hundred {1} {2}", numbersFrom0to20[hundreds], numbersFrom20to90[tens], numbersFrom0to20[ones]);
                }
                
            }
        }
    }
}
