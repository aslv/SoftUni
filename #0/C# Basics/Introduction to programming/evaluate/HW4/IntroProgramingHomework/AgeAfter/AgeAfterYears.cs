//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
using System;

    class AgeAfter
    {
        static void Main()
        {

        Console.WriteLine("Enter your birthday(try dd.mm.yyyy)");
        DateTime birthDay = DateTime.Parse(Console.ReadLine());
        DateTime today = DateTime.Now;
        int age = today.Year - birthDay.Year;
        Console.WriteLine("You are {0} years old.", age);
        Console.WriteLine("After 10 years you will be {0} years old", age + 10);
        }
    }

