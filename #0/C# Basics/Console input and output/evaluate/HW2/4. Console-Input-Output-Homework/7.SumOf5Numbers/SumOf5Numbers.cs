using System;

class SumOf5Numbers
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        input = input.Replace(',', '.');
        decimal sum = 0.00m;
        string[] numbersAsStrings = input.Split(' ');
        for (int i = 0; i < numbersAsStrings.Length; i++)
        {
            sum += decimal.Parse(numbersAsStrings[i]);
        }
        Console.WriteLine(sum);
    }
}
