using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestNonDecreasingSubsequence
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Program that reads a sequence of n integers and finds in it the longest non-decreasing subsequence.");
                 
            Console.WriteLine("Write n=");
            int n = int.Parse(Console.ReadLine());
            int[] list = new int[n];  
            Console.WriteLine("Write {0} numbers:", n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Write number {0}", i + 1);
                list[i] = int.Parse(Console.ReadLine());
            }

            //make dictionary with key, value: index of first element of the subsequence, the subsequence
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>{};
            bool findSmallerNumber = false;
            for (int j = 0; j < n; j++)
            {
                findSmallerNumber = false;
                dict[j] = new List<int> { list[j] };
                List<int> c = dict[j];
                for (int s = 1;  s < n; s++)
                {
                    if (c.Last() <= list[s] )
                    {
                        c.Add(list[s]);
                        if (!findSmallerNumber)
                        {
                            j = s;
                        }
                    }
                    else
                    {
                        findSmallerNumber = true;
                    }
                }
            }
            
            foreach (List<int> value in dict.Values)
            {
                foreach (int element in value)
                {
                    Console.Write(element+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
