using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem02_Gravitation_on_the_Moon
{
    class Problem02_Gravitation_on_the_Moon
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your weight: ");
            float weight = float.Parse(Console.ReadLine());
            weight = (float) (weight * 0.17);
            Console.WriteLine("Your weight on the Moon would be {0}", weight);

        }
    }
}
