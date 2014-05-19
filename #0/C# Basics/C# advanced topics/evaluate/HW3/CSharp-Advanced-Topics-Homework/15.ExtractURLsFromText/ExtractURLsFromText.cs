using System;

class ExtractURLsFromText
{
    static void Main()
    {
        /* 15. Write a program that extracts and prints all URLs from given text. URL can be in only two
         * formats:
         * • http://something, e.g. http://softuni.bg, http://forums.softuni.bg, http://www.nakov.com 
         * • www.something.domain, e.g. www.nakov.com, www.softuni.bg, www.google.com
         * 
         * Examples:
         *                          Input                             |      Output
         * The site nakov.com can be access from http://nakov.com or  |  http://nakov.com
         * www.nakov.com. It has subdomains like mail.nakov.com and   |  www.nakov.com
         * svetlin.nakov.com. Please check http://blog.nakov.com for  |  http://blog.nakov.com
         * more information.                                          |
         */

        //Console.Write("Enter text here: ");
        //string input = Console.ReadLine();

        string input = "The site nakov.com can be access from http://nakov.com or www.nakov.com." + 
                        " It has subdomains like mail.nakov.com and svetlin.nakov.com." +  
                        "Please check http://blog.nakov.com for more information.";

        string http = "http://";
        string www = "www";
        string[] data = input.Split(' ');
        //string http = @"/^(https?:\/\/)?([\da-z\.-]+)\.([a-z\.]{2,6})([\/\w \.-]*)*\/?$/";

        for (int i = 0; i < data.Length; i++)
        {
            if (data[i].StartsWith(http) || data[i].StartsWith(www))
            {
                if (data[i].EndsWith("."))
                {
                    data[i] = data[i].Remove(data[i].LastIndexOf('.'));
                }
                Console.WriteLine(data[i]);
            }
        }
    }                  
}                      
                       