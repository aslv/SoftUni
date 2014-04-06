using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? a = null;
        Console.WriteLine(a);
        Console.WriteLine(a + 33);   //when adding to null, result is still null
        a = 35;
        Console.WriteLine(a);
        double? b = null;
        Console.WriteLine(b);
        b += 564.676;
        Console.WriteLine(b);   //same with double
        b = 103.64976;
        Console.WriteLine(b);
    }
}