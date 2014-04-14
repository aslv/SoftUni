using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Please enter an integer n: ");
        int n = int.Parse(Console.ReadLine());

        int firstNumber = 0;
        int secondNumber = 1;
        int temp;
        Console.Write("{0} ", 0);

        for (int i = 0; i < n -1; i++)
        {
            temp = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
            
            Console.Write("{0} ", firstNumber);
        }
    }
}

