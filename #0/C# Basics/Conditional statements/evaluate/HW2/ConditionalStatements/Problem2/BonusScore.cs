using System;
   class BonusScore
    {
        static void Main(string[] args)
        {
            Console.Write("Score is: ");
            int score = int.Parse(Console.ReadLine());
            int bonus=0;
            if (score >= 1 && score <= 3) bonus = score * 10;
            if (score >= 4 && score <= 6) bonus = score * 100;
            if (score >= 7 && score <= 9) bonus = score * 1000;
            if (score == 0 || score > 9)
            { Console.WriteLine("invalid score"); }
            else Console.WriteLine("Bonused Score is "+ bonus); 
        }
    }
