using System;

class ExchangeValues
{
    static void Main()
    {
        int a = 5, b = 10;
        a += b;
        b = a - b;
        a -= b;
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
}