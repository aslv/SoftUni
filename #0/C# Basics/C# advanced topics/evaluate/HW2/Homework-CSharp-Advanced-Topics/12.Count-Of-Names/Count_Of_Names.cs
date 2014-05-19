using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Count_Of_Names
{
    static void Main()
    {
        string namesString = Console.ReadLine();
        string[] allNames = namesString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        List<string> letters = allNames.ToList<string>();

        letters.Sort();

        int counter = 1;
        for (int i = 1; i < letters.Count; i++)
        {
            if (letters[i] == letters[i - 1])
            {
                counter++;
            }
            else
            {
                Console.WriteLine("{0} --> {1}", letters[i - 1], counter);
                counter = 1;
            }

            if (i == letters.Count - 1)
            {
                Console.WriteLine("{0} --> {1}", letters[i], counter);
            }
        }
    }
}