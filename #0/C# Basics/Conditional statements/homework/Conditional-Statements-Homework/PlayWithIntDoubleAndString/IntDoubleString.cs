using System;

namespace PlayWithIntDoubleAndString
{
    class IntDoubleString
    {
        static void Main()
        {
            Console.WriteLine(@"Please choose a type:
1 --> int
2 --> double
3 --> string");
            int type = int.Parse(Console.ReadLine());
            Console.Write("Please enter a ");
            switch (type)
            {
                case 1:
                    Console.Write("integer: ");
                    Console.WriteLine(int.Parse(Console.ReadLine()) + 1);
                    break;
                case 2:
                    Console.Write("double: ");
                    Console.WriteLine(double.Parse(Console.ReadLine()) + 1);
                    break;
                case 3:
                    Console.Write("string: ");
                    Console.WriteLine("{0}*", Console.ReadLine());
                    break;
                default:
                    Console.Error.WriteLine("INVALID TYPE !!!");
                    break;
            }
        }
    }
}
