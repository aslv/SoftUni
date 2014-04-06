using System;
class LongSequence
{
    static void Main()
    {
        for (int i = 2; i <= 1000; i++)
        {
            if ((i % 2) == 1) Console.WriteLine("-" + i);
            if ((i % 2) == 0) Console.WriteLine(i);
        }
    }
}
