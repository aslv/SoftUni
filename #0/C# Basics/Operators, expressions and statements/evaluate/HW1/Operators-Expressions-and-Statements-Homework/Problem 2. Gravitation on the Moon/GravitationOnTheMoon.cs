using System;

namespace Problem_2.Gravitation_on_the_Moon
{
    class GravitationOnTheMoon
    {
        static void Main()
        {
            Console.Write("Enter your weight: ");
            double weight = double.Parse(Console.ReadLine());
            double weightOnTheMoon = weight * 0.17;
            Console.WriteLine(weightOnTheMoon);
        }
    }
}
