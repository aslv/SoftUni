using System;

class NumbersDividedByANumber
{
    static void Main(string[] args)
    {
         int numFirst = int.Parse(Console.ReadLine());
        int numLast = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = numFirst; i <= numLast; i++)
        {
            int divider = i % 5;
            if (divider == 0)
            {
                sum = sum + 1;
            }
        }
        Console.WriteLine(sum);
        }
}

