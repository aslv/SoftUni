using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimesInGivenRange
{
    class Program
    {
        static bool IsPrime(long n)
        {
            if (n < 2)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0) return false;
                }
            }
            return true;
        }

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primeNumbers = new List<int> { };
            int length = 0;
            if (startNum > endNum)
            {
                Console.WriteLine("(empty list)");
            }
            else
            {
                for (int i = startNum; i <= endNum; i++)
                {
                    if (Program.IsPrime(i))
                    {
                        primeNumbers.Add(i);
                        length++;
                    }
                }
            }
            return primeNumbers;
        }

        static void Main()
        {
            Console.WriteLine("Program that calculates all prime numbers in given range and returns them as list of integers.");
            Console.WriteLine("Write number to start the range");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Write number to end the range");
            int end = int.Parse(Console.ReadLine());
            List<int> range = Program.FindPrimesInRange(start, end);
            Console.WriteLine("The prime numbers between {0} and {1} are:", start, end);
            range.ForEach(Console.WriteLine);
        }
    }
}
