using System;

class PrimeNumberCheck
{
    static void Main()
    {

        int numberToCheck = int.Parse(Console.ReadLine());
        bool isPrime = true;
        if (numberToCheck < 0)
        {
            isPrime = false;
        }
        if ((numberToCheck == 1) || (numberToCheck == 0))
        {
            isPrime = false;

        }
        if (numberToCheck == 2)
        {
            isPrime = true;
        }
        else if (numberToCheck % 2 == 0)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 3; i <= Math.Sqrt(numberToCheck); i++)
            {
                if (numberToCheck % i == 0)
                {
                    isPrime = false;
                }
            }
        }

        Console.WriteLine(isPrime);




    }
}


