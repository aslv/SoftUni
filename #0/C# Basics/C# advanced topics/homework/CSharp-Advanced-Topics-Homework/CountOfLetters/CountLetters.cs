using System;

namespace CountOfLetters
{
    class CountLetters
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            char[] letters = new char[values.Length];
            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = char.Parse(values[i]);
            }
            int[] count = new int[26];
            foreach (char letter in letters)
            {
                count[letter - 'a']++;
            }
            for (int i = 0; i < 26; i++)
            {
                if (count[i] > 0)
                {
                    Console.WriteLine("{0} -> {1}", (char)(i + 'a'), count[i]);
                }
            }
        }
    }
}
