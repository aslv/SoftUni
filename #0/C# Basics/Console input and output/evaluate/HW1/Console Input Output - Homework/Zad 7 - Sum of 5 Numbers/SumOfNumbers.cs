using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_7___Sum_of_5_Numbers
{
    class SumOfNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Input numbers: ");
            string stringOfNumbers = Console.ReadLine();
            string[] newstring = stringOfNumbers.Split(' ');
            double sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += double.Parse(newstring[i]);
            }
            Console.WriteLine("Sum = {0}", sum);
        }
    }
}
