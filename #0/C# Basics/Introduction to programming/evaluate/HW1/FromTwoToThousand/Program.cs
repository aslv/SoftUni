using System;

namespace FromTwoToThousand
{
    class Program
    {
        static void Main()
        {
            for (int a=2; a<1001; a++)
            {
                if (a % 2==1)
                    Console.WriteLine("-");
                    Console.WriteLine(a + ",");
            }
        }
    }
}
