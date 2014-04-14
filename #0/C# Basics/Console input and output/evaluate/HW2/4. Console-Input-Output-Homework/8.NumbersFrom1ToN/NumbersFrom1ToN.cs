using System;

class NumbersFrom1ToN
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insert n:");
        int num = int.Parse(Console.ReadLine());            
        Console.WriteLine("");                              
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine(i);
        }
    }
}
