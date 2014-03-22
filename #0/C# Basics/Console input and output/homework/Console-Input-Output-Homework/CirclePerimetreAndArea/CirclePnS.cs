using System;

namespace CirclePerimetreAndArea
{
    class CirclePnS
    {
        static void Main()
        {
            Console.Write("r = ");
            float r = float.Parse(Console.ReadLine());
            Console.WriteLine("The circumference (perimetre) is {0:0.00}", 2 * Math.PI * r);
            Console.WriteLine("The surface (area) is {0:0.00}", Math.PI * r * r);
        }
    }
}
