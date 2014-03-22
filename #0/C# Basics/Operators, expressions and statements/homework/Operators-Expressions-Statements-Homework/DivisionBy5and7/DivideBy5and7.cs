using System;

namespace DivisionBy5and7
{
    class DivideBy5and7
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n % 35 == 0);
        }
    }
}
