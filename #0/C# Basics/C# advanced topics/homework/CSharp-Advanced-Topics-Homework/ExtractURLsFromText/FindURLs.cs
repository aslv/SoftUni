using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtractURLsFromText
{
    class FindURLs
    {
        static void Main()
        {
            string text = "";
            // text = Console.In.ReadToEnd(); // UNCOMMENT THIS AND COMMENT NEXT LINES IF YOU WANT TO FOLLOW EXACTLY THE TASK
            string line;
            while ((line = Console.ReadLine()) != "")
            {
                text += line;
            }
            char[] delims = new char[] { '\0', '\t', ' ', '\n', '\r' };
            string[] words = text.Split(delims, StringSplitOptions.RemoveEmptyEntries);
            List<string> URLs = new List<string>();
            foreach (string word in words)
            {
                if (word.Length > 6)
                {
                    if (word.Substring(0, 4).Equals("www.") && word.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries).Length == 3)
                    // because we do not allow subdomains in "www" form - see the task
                    {
                        URLs.Add(word);
                    }
                }
                if (word.Length > 7)
                {
                    if (word.Substring(0, 7).Equals("http://"))
                    {
                        URLs.Add(word);
                    }
                }
            }
            Console.WriteLine();
            foreach (string URL in URLs)
            {
                Console.WriteLine(URL[URL.Length - 1] == '.' ? URL.Remove(URL.Length - 1) : URL);
            }
        }
    }
}
