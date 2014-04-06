using System;

class Problem_16_BitExchangeAdvanced
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

        for (int i = p, j = q; i < ((p+k)-1); i++, j++)
			{

            int mask1 = 1 << i;
            int mask2 = 1 << j;
            uint bit1 =(uint) (number & mask1);
            uint bit2 =(uint) (number & mask2);

            if (bit1 == 0)
            {
                int replacer = 1 << j;
                number = (uint)(number & ~replacer);
            }
            else
            {
                int replacer = 1 << j;
                number = (uint)(number | replacer);
            }
            if (bit2 == 0)
            {
                int replacer = 1 << i;
                number = (uint)(number & ~replacer);
            }
            else
            {
                int replacer = 1 << i;
                number = (uint)(number | replacer);
            }

        }
             Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            Console.WriteLine(number);
    }


}


