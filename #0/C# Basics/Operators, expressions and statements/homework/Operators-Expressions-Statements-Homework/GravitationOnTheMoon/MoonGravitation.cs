using System;

namespace GravitationOnTheMoon
{
    class MoonGravitation
    {
        static void Main()
        {
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("The weight on the Monn would be {0}", weight * 0.17);
        }
    }
}
