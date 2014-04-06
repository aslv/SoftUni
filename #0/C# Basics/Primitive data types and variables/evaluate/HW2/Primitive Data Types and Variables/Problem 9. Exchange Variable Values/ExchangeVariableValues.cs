using System;

class ExchangeVariableValues
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;
        Console.WriteLine(a);
        Console.WriteLine(b);

        a = b = 10;
        b = b/2;

        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}
