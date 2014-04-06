using System;

namespace Current_Date_and_Time
{
    class Program
    {
        static void Main()
        {
            DateTime time = DateTime.Now;              
            string format = "MMM ddd d HH:mm yyyy";    
            Console.WriteLine(time.ToString(format));
        }
    }
}
