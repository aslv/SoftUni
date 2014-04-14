using System;
    class PlayCard
    {
        static void Main()
        {
            string ch = (Console.ReadLine());
            if (ch=="2"||ch=="3"||ch=="4"||ch=="5"||ch =="6"||ch=="7"||ch =="8"||ch =="9"||ch=="10"||ch=="J"||ch=="D"||ch=="K"||ch=="A")
                Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
