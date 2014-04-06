using System;

namespace ExchangeVariableValues
{
    class ExchangeValues
    {
        static void Main()
        {
            int a = 13;
            int b = 10;
            Console.WriteLine("Value for \"a\" is {0}",a);
            Console.WriteLine("Value for \"b\" is {0}", b);
            b = b - a;
            a = b + b;
            Console.WriteLine("Exchange value for variable \"a\" is {0}",a);
            Console.WriteLine("Exchange value for variable \"b\" is {0}", b);
        }
    }
}
