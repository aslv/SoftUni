using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1
{
    class FighterAttack
    {
        static void Main()
        {
            int[] Px = new int[2];
            int[] Py = new int[2];
            int Fx, Fy, d;
            Px[0] = int.Parse(Console.ReadLine());
            Py[0] = int.Parse(Console.ReadLine());
            Px[1] = int.Parse(Console.ReadLine());
            Py[1] = int.Parse(Console.ReadLine());
            Fx = int.Parse(Console.ReadLine());
            Fy = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            Array.Sort(Px);
            Array.Sort(Py);
            Fx += d;
            int result = 0;
            if (Fx >= Px[0] && Fx <= Px[1] && Fy >= Py[0] && Fy <= Py[1])
            {
                result += 100;
            }
            Fx++;
            if (Fx >= Px[0] && Fx <= Px[1] && Fy >= Py[0] && Fy <= Py[1])
            {
                result += 75;
            }
            Fx--; Fy++;
            if (Fx >= Px[0] && Fx <= Px[1] && Fy >= Py[0] && Fy <= Py[1])
            {
                result += 50;
            }
            Fy -= 2;
            if (Fx >= Px[0] && Fx <= Px[1] && Fy >= Py[0] && Fy <= Py[1])
            {
                result += 50;
            }

            Console.WriteLine("{0}%", result);
        }
    }
}
