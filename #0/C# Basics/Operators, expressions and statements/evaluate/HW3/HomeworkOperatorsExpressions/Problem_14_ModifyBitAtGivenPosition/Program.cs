using System;

class Problem_14_ModifyBitAtGivenPosition
{
    static void Main()
    {
        int numbertoCheck = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        int bitValue = int.Parse(Console.ReadLine());
        int mask = 0;
        int numberAndMask = 0;
        if (bitValue == 1)
        {
            mask = 1 << position;
            numberAndMask = numbertoCheck | mask; 
        }
        else
        {
            mask = ~(1 << position);
            numberAndMask = numbertoCheck & mask;

        }
        Console.WriteLine(numberAndMask);
    }
}

