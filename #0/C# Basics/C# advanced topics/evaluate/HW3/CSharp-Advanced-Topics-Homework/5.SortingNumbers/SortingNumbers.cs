using System;

class SortingNumbers
{
    static void Main()
    {
        /* 5. Write a program that reads a number n and a sequence of n integers, sorts them and prints them.
         * Examples:
         * 
         * Input | Output     Input | Output
         *   5   |   -3          3  |  0
         *   3   |    0          0  |  0
         *  -3   |    2          1  |  1
         *   2   |    3          0  |
         *  122  |   122
         *   0   |
         */

        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = Input(n);
        
        Print(SortNumbers(numbers));
    }

    static int[] Input(int n)
    {
        int[] numbers = new int[n];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("element {0}: ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        return numbers;
    }
    
    static int[] SortNumbers(int[] numbers)
    {
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] > numbers[j])
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
            }
        }

        return numbers;
    }

    static void Print(int[] numbers)
    {
        foreach (int item in numbers)
        {
            Console.WriteLine(item);
        }
    }
}