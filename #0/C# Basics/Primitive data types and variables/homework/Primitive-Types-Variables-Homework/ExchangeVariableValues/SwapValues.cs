using System;

namespace ExchangeVariableValues
{
    class SwapValues
    {
        static void Main()
        {
            int a = 5, b = 10;
            Console.WriteLine("a = {0} and b = {1}.", a, b);
            a += b;
            b = a - b;
            a -= b;
            Console.WriteLine("Now a = {0} and b = {1}!", a, b);
        }
    }
}
