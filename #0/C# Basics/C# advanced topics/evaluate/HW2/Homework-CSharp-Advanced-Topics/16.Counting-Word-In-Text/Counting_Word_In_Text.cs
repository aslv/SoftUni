using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Counting_Word_In_Text
{
    static int CompareWords(string inputWord, string inputText)
    {
        string[] allWords = inputText.Split(
            new char[] { ' ', '.', ',', '"', '@', '!', '?', '/', '\\', ':', ';', '(', ')' },
            StringSplitOptions.None);

        int counter = 0;

        for (int i = 0; i < allWords.Length; i++)
        {
            if (string.Equals(allWords[i], inputWord, StringComparison.OrdinalIgnoreCase))
            {
                counter++;
            }
        }
        return counter;
    }
    static void Main()
    {
        string keyWord = Console.ReadLine();
        string someText = Console.ReadLine();

        int result = CompareWords(keyWord, someText);
        Console.WriteLine(result);
    }
}