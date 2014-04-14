using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.NumbersFrom1ToN
{
    class NumbersFrom1ToN
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
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
