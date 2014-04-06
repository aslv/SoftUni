using System;

namespace _01.DeclareVariables
{
    class DeclareVar
    {
        static void Main()
        {
            ushort firstVar = 52130;
            sbyte secondVar = -115;
            int thirdVar = 4825932;
            byte fourthVar = 97;
            short fifthVar = -10000;

            //Definition of new array, outside of this lesson
            string[] valueStr = { "ushort", "sbyte", "int", "byte", "short" };
            //The first variable
            Console.Write("The type of first variable is    ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(valueStr[0]);
            Console.ResetColor();
            Console.WriteLine(" with value  --> {0}", firstVar);
            //The second vriable
            Console.Write("The type of second variable is   ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(valueStr[1]);
            Console.ResetColor();
            Console.WriteLine("  with value  --> {0}", secondVar);
            //The third variable
            Console.Write("The type of third variable is    ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(valueStr[2]);
            Console.ResetColor();
            Console.WriteLine("    with value  --> {0}", thirdVar);
            //The fourth variable
            Console.Write("The type of fourth variable is   ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(valueStr[3]);
            Console.ResetColor();
            Console.WriteLine("   with value  --> {0}", fourthVar);
            //The fifth variable
            Console.Write("The type of fifth variable is    ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(valueStr[4]);
            Console.ResetColor();
            Console.WriteLine("  with value  --> {0}", fifthVar);

        }
    }
}