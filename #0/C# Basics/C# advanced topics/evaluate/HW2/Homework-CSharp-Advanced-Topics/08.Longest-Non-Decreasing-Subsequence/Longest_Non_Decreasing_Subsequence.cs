﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Longest_Non_Decreasing_Subsequence
{
    static void Main()
    {
        //Input
        string input = Console.ReadLine();
        string[] inputElements = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int[] elementsArray = new int[inputElements.Length];
        for (int i = 0; i < inputElements.Length; i++)
        {
            elementsArray[i] = int.Parse(inputElements[i]);
        }

        List<int> longestSequenceList = new List<int>();

        int startIndex = 0;
        int lenghtCount = 1;
        int currentCount = 1;

        for (int i = 0; i < elementsArray.Length - 1; i++)
        {
            if (elementsArray[i] == elementsArray[i + 1])
            {
                currentCount++;

                if (currentCount > lenghtCount)
                {
                    lenghtCount = currentCount;
                    startIndex = (i + 1) - (lenghtCount - 1);
                }
            }
            else
            {
                currentCount = 1;
            }
        }
        for (int i = 0; i < lenghtCount; i++)
        {
            longestSequenceList.Add(elementsArray[startIndex + i]);
        }

        long combinations = 1;
        for (int i = 0; i < elementsArray.Length; i++)
        {
            combinations *= 2;
        }

        for (long combination = 1; combination <= combinations; combination++)
        {
            string binary = Convert.ToString(combination, 2).PadLeft(elementsArray.Length, '0');
            char[] tempArr = binary.ToCharArray();
            Array.Reverse(tempArr);
            string revBinary = new string(tempArr);

            List<int> tempList = new List<int>();
            int bitsCount = 0;

            for (int i = 0; i < elementsArray.Length; i++)
            {
                if (revBinary[i] == '1')
                {
                    tempList.Add(elementsArray[i]);
                    bitsCount++;
                }
            }

            if (bitsCount < longestSequenceList.Count)
            {
                continue;
            }

            int currentLenght = 0;
            List<int> currentLongestSeq = new List<int>();

            if (tempList.Count > 1)
            {
                int biggestNum = tempList[0];
                currentLongestSeq.Add(biggestNum);

                for (int i = 0; i < tempList.Count - 1; i++)
                {
                    if (tempList[i + 1] > biggestNum)
                    {
                        biggestNum = tempList[i + 1];

                        currentLongestSeq.Add(biggestNum);
                    }
                }

                currentLenght = currentLongestSeq.Count;
            }

            if (currentLenght > longestSequenceList.Count)
            {
                longestSequenceList = currentLongestSeq;
            }
        }

        //Output
        for (int i = 0; i < longestSequenceList.Count; i++)
        {
            Console.Write(longestSequenceList[i] + " ");
        }
        Console.WriteLine();
    }
}