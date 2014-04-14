using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.NumbersNotDivisibleBy3And7
{
    class NumbersNotDivisibleBy3And7
    {
        static void Main(string[] args)
        {
            int Alfa = 0;
            bool LenghtBit = false;
            while (LenghtBit == false)
            {
                Console.WriteLine("Give me a number: ");
                Alfa = int.Parse(Console.ReadLine());
                if (Alfa < 0)
                {
                    Console.WriteLine("The entered integer is not meeting the current requrements");
                }
                else
                {
                    break;
                }
            }

            for (int i = 1; i <= Alfa; i++)
            {
                if ((i % 3 == 0) || (i % 7 == 0))
                {
                    continue;
                }
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

        }
    }
}
