using System;

class CopyrightSymbol
{
    static void Main(string[] args)
    {
        char symbol = '\u00A9';
        Console.WriteLine("   " + symbol);
        Console.WriteLine("  " + symbol + " " + symbol);
        Console.WriteLine(" " + symbol + "   " + symbol);
        Console.WriteLine(symbol + " " + symbol + " " + symbol + " " + symbol);
    }
}