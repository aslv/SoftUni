using System;

namespace _07.StringsAndObject
{
    class StringAndObj
    {
        static void Main()
        {
            string greeting = "Hello ";
            string whoGreet = "World";
            object varObj = greeting + whoGreet;
            string tCast = varObj.ToString();
            Console.WriteLine("I say {0} ", tCast);
        }
    }
}
