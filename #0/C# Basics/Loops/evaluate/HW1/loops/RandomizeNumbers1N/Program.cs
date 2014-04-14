using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeNumbers1N
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            bool[] printed = new bool[n + 1];
            Random randomNum = new Random();
            int numberToPrint;
            for (int i = 1; i <= n; i++)
            {
                numberToPrint = randomNum.Next(1, n + 1);
                if (!printed[numberToPrint])
                {
                    Console.Write(numberToPrint + " ");
                    printed[numberToPrint] = true;
                }
                else
                {
                    i--;
                }
            }
        }
    }

}