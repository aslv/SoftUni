using System;

namespace BonusScore
{
    class Bonus
    {
        static void Main()
        {
            Console.Write("Enter score in range [1..9]: ");
            int? score = int.Parse(Console.ReadLine());
            if (score >= 1 && score <= 3)
            {
                score *= 10;
            }
            else if (score >= 4 && score <= 6)
            {
                score *= 100;
            }
            else if (score >= 7 && score <= 9)
            {
                score *= 1000;
            }
            else
            {
                score = null;
            }
            Console.WriteLine(score != null ? "Now scores are " + score : "invalid score");
        }
    }
}
