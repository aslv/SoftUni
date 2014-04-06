using System;

class Problem_13_CheckBitAtGivenPosition
{
    static void Main()
    {
        int numbertoCheck = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        int mask = 1 << position;
        int numberAndMask = numbertoCheck & mask;
        int bit = numberAndMask >> position;

        bool bitIsOne = false;
        if (bit == 1)
        {
            bitIsOne = true;
        }
        
        Console.WriteLine(bitIsOne);
    }
}

