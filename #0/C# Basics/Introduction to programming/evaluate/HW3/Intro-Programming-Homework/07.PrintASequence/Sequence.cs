using System;
class Sequence
{
    static void Main()
    {
        //2, -3, 4, -5, 6, -7, ...
        int a = 2;
        int b = -3;
        Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", a, b, a + 2, b - 2, a + 4, b - 4, a + 6, b - 6, a + 8, b - 8);
    }
}
