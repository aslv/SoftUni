using System;
using System.Collections.Generic;

namespace PrimesInGivenRange
{
    class Primes
    {
        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> result = new List<int>();
            if (startNum > endNum)
            {
                return result;
            }
            if (startNum < 2)
            {
                startNum = 2;
            }
            bool isPrime;
            for (int current = startNum; current <= endNum; current++)
            {
                isPrime = true;
                for (int i = 2, limit = (int)Math.Sqrt(current); i <= limit; i++)
                {
                    if (current % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    result.Add(current);
                }
            }
            return result;
        }

        static void PrintList(params int[] elements)
        {
            if (elements.Length == 0)
            {
                return;
            }
            int lastButOne = elements.Length - 1;
            for (int i = 0; i < lastButOne; i++)
            {
                Console.Write("{0}, ", elements[i]);
            }
            Console.WriteLine(elements[lastButOne]);
        }

        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            PrintList(FindPrimesInRange(start, end).ToArray());
        }
    }
}
