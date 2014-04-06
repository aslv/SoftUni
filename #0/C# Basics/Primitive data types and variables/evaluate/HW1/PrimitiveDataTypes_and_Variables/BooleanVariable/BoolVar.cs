using System;

namespace BooleanVariable
{
    class BoolVar
    {
        static void Main()
        {
            int gender;
            Console.WriteLine("What is your gender?");
            gender = Console.Read();           
            bool isFemale = (gender == 109 || gender == 77);
            Console.WriteLine("My gender is {0}", isFemale);
        }
    }
}
