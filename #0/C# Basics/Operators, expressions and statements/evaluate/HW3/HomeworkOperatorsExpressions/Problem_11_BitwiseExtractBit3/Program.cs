using System;

class Problem_11_BitwiseExtractBit3
{
    static void Main()
    {
        int numbertoCheck = int.Parse(Console.ReadLine());
        int position = 3;
        int mask = 1 << position;
        int numberAndMask = numbertoCheck & mask;
        int bit = numberAndMask >> position;
        Console.WriteLine(bit);
    }
}

