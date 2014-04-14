using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkHours
{
    class Task1
    {
        static void Main()
        {
            int h = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            double actualDays = d * 0.9;
            double workingHours = actualDays * 12 * (p / 100.0);
            int difference = (int)workingHours - h;

            if (difference >= 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.WriteLine(difference);
        }
    }
}
