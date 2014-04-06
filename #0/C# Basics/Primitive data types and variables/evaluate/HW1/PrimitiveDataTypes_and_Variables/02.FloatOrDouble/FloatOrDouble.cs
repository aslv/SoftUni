using System;

namespace _02.FloatOrDouble
{
    class FloatOrDouble
    {
        static void Main()
        {
            double firstFloatVar = 34.567839023;
            float secondFloatVar = 12.345f;
            double thirdFloatVar = 8923.1234857;
            float fourthFloatVar = 3456.091f;

            //Definition of new array - outside of this lesson
            string[] valueStr = { "double", "float", "double", "float" };
            //The first variable
            Console.Write("The type of 1st floating point variable is ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(valueStr[0]);
            Console.ResetColor();
            Console.WriteLine(" with value  --> {0}", firstFloatVar);
            //The second vriable
            Console.Write("The type of 2nd floating point variable is ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(valueStr[1]);
            Console.ResetColor();
            Console.WriteLine("  with value  --> {0}", secondFloatVar);
            //The third variable
            Console.Write("The type of 3rd floating point variable is ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(valueStr[2]);
            Console.ResetColor();
            Console.WriteLine(" with value  --> {0}", thirdFloatVar);
            //The fourth variable
            Console.Write("The type of 4th floating point variable is ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(valueStr[3]);
            Console.ResetColor();
            Console.WriteLine("  with value  --> {0}", fourthFloatVar);
        }
    }
}
