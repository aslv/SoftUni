using System;

class FloatCompare
{
    static void Main(string[] args)
    {
        double a = 4.999999;
        double b = 4.999998;

        double firstNumber =  Math.Abs(a);
        double secondNumber = Math.Abs(b);
        double difference = Math.Abs(firstNumber - secondNumber);
        double eps = 0.000001;

        if (difference <= eps)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}