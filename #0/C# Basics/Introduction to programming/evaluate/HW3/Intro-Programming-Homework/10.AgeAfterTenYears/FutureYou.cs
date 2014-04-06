using System;
class FutureYou
{
    static void Main(string[] args)
    {
        Console.Write("Enter your birthday in format(dd.mm.yyyy): ");
        DateTime userBirthday = DateTime.Parse(Console.ReadLine());
        DateTime today = DateTime.Now;
        int ageNow, ageThen;
        if (userBirthday.Month - today.Month < 0)
        {
            if (userBirthday.Day - today.Day < 0)
                ageNow = today.Year - userBirthday.Year;
            else
                ageNow = today.Year - userBirthday.Year - 1;
        }
        else ageNow = today.Year - userBirthday.Year - 1;
        ageThen = ageNow + 10;
        Console.WriteLine("Now you are {0} years old. In 10 years you will be {1} years old.", ageNow, ageThen);

    }
}
