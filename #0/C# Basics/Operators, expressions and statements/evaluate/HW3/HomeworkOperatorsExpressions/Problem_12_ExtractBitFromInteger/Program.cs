using System;

class Problem_12_ExtractBitFromInteger
{
    static void Main()
    {
        int numbertoCheck = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        int mask = 1 << position;
        int numberAndMask = numbertoCheck & mask;
        int bit = numberAndMask >> position;
        Console.WriteLine(bit);
    }
}

