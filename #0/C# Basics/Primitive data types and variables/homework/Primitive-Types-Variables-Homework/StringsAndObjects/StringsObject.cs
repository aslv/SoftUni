using System;

namespace StringsAndObjects
{
    class StringsObject
    {
        static void Main()
        {
            string greeting0 = "Hello";
            string greeting1 = "World";
            object greetingObj = greeting0 + " " + greeting1;
            Console.WriteLine(greetingObj);
            string greetingStr = greetingObj.ToString();
            Console.WriteLine(greetingStr);
        }
    }
}
