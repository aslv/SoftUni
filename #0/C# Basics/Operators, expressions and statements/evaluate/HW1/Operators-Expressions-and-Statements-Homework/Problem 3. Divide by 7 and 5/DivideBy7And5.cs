using System;

namespace Problem_3.Divide_by_7_and_5
{
    class DivideBy7And5
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            
            bool isDivided = (number % 5 == 0) && (number % 7 == 0);
            Console.WriteLine("The number can be divided by 5 and 7 -> " + isDivided);
        }
    }
}
