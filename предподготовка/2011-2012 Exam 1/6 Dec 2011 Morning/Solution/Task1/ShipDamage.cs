using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1
{
    class ShipDamage
    {
        static void Main()
        {
            int[] Sx = new int[2], Sy = new int[2], Cx = new int[3], Cy = new int[3];
            int h;
            Sx[0] = int.Parse(Console.ReadLine());
            Sy[0] = int.Parse(Console.ReadLine());
            Sx[1] = int.Parse(Console.ReadLine());
            Sy[1] = int.Parse(Console.ReadLine());
            h = int.Parse(Console.ReadLine());
            Cx[0] = int.Parse(Console.ReadLine());
            Cy[0] = int.Parse(Console.ReadLine());
            Cx[1] = int.Parse(Console.ReadLine());
            Cy[1] = int.Parse(Console.ReadLine());
            Cx[2] = int.Parse(Console.ReadLine());
            Cy[2] = int.Parse(Console.ReadLine());

            Array.Sort(Sx);
            Array.Sort(Sy);
            int damage = 0;
            for (int i = 0; i < 3; i++)
            {
                Cy[i] = 2 * h - Cy[i];

                if (Cx[i] > Sx[0] && Cx[i] < Sx[1] && Cy[i] > Sy[0] && Cy[i] < Sy[1])
                {
                    damage += 100;
                    continue;
                }

                if ((Cx[i] == Sx[0] || Cx[i] == Sx[1]) && Cy[i] > Sy[0] && Cy[i] < Sy[1])
                {
                    damage += 50;
                    continue;
                }
                if ((Cy[i] == Sy[0] || Cy[i] == Sy[1]) && Cx[i] > Sx[0] && Cx[i] < Sx[1])
                {
                    damage += 50;
                    continue;
                }

                if ((Cx[i] == Sx[0] || Cx[i] == Sx[1]) && (Cy[i] == Sy[0] || Cy[i] == Sy[1]))
                {
                    damage += 25;
                }
            }

            Console.WriteLine("{0}%", damage);
        }
    }
}
