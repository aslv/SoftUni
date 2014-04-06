using System;

class Problem_15_BitsExchange
{
    static void Main()
    {
        uint numberToCheck = uint.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(numberToCheck, 2).PadLeft(32, '0'));
        int mask = 1 << 3;
        uint thirdBit = (uint)(numberToCheck & mask) >> 3;

         mask = 1 << 24;
        uint twentyForthBit = (uint)(numberToCheck & mask) >> 24;
        if (thirdBit == 0)
        {
            mask = ~(1 << 24);
            numberToCheck = (uint) (numberToCheck & mask); 
        }
        else if (thirdBit == 1)
        {
            mask = 1 << 24;
            numberToCheck = (uint)(numberToCheck | mask);
        }
        if (twentyForthBit == 0)
        {
            mask = ~(1 << 3);
            numberToCheck = (uint)(numberToCheck & mask);
        }
        else if (twentyForthBit == 1)
        {
            mask = 1 << 3;
            numberToCheck = (uint)(numberToCheck | mask);
        }

        mask = 1 << 4;
        uint forthBit = (uint)(numberToCheck & mask) >> 4;
        
        mask = 1 << 25;
        uint twentyFifthBit = (uint)(numberToCheck & mask) >> 25;
        if (forthBit == 0)
        {
            mask = ~(1 << 25);
            numberToCheck = (uint)(numberToCheck & mask);
        }
        else if (forthBit == 1)
        {
            mask = 1 << 25;
            numberToCheck = (uint)(numberToCheck | mask);
        }
        if (twentyFifthBit == 0)
        {
            mask = ~(1 << 4);
            numberToCheck = (uint)(numberToCheck & mask);
        }
        else if (twentyFifthBit == 1)
        {
            mask = 1 << 4;
            numberToCheck = (uint)(numberToCheck | mask);
        }
        mask = 1 << 5;
        uint fifthBit = (uint)(numberToCheck & mask) >> 5;
        mask = 1 << 26;
        uint twentySixthBit =(uint) (numberToCheck & mask) >> 26;
        if (fifthBit == 0)
        {
            mask = ~(1 << 26);
            numberToCheck = (uint)(numberToCheck & mask);
        }
        else if (fifthBit == 1)
        {
            mask = 1 << 26;
            numberToCheck = (uint)(numberToCheck | mask);
        }
        if (twentySixthBit == 0)
        {
            mask = ~(1 << 5);
            numberToCheck = (uint)(numberToCheck & mask);
        }
        else if (twentySixthBit == 1)
        {
            mask = 1 << 5;
            numberToCheck = (uint)(numberToCheck | mask);
        }
        Console.WriteLine(Convert.ToString(numberToCheck, 2).PadLeft(32, '0'));
        Console.WriteLine(numberToCheck);

    }
}

