using System;

class NullInteger
{
    static void Main(string[] args)
    {
        int? firstNumber = null;
        double? secondNumber = null;

        Console.WriteLine(firstNumber);
        Console.WriteLine(secondNumber);

        firstNumber = 10;
        secondNumber = 17;

        Console.WriteLine(firstNumber);
        Console.WriteLine(secondNumber);
    }
}
