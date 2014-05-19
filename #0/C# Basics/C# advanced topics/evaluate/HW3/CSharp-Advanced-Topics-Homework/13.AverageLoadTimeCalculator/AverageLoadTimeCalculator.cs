using System;
using System.Collections.Generic;
//using System.Linq;

class AverageLoadTimeCalculator
{
    static void Main()
    {
        /* 13. We have a report that holds dates, web site URLs and load times (in seconds) in the same format
         * like in the examples below. Your tasks is to calculate the average load time for each URL. Print the 
         * URLs in the same order as they first appear in the input report. Print the output in the format given
         * below. Use double floating-point precision. Examples:
         * 
         *                  Input                                       Output
         * 2014-Mar-02 11:33 http://softuni.bg 8.37725    |  http://softuni.bg -> 7.813625
         * 2014-Mar-02 11:34 http://www.google.com 1.335  |  http://www.google.com -> 2.24875
         * 2014-Mar-03 21:03 http://softuni.bg 7.25       |
         * 2014-Mar-03 22:00 http://www.google.com 2.44   |
         * 2014-Mar-03 22:01 http://www.google.com 2.45   |
         * 2014-Mar-03 22:01 http://www.google.com 2.77   |
         */

        string[] input = {
                             "2014-Mar-02 11:33 http://softuni.bg 8.37725",  
                             "2014-Mar-02 11:34 http://www.google.com 1.335",
                             "2014-Mar-03 21:03 http://softuni.bg 7.25",     
                             "2014-Mar-03 22:00 http://www.google.com 2.44", 
                             "2014-Mar-03 22:01 http://www.google.com 2.45", 
                             "2014-Mar-03 22:01 http://www.google.com 2.77" 
                         };

        //string[] input = {
        //                    "2014-Apr-01 02:01 http://softuni.bg 8.37725",
        //                    "2014-Apr-01 02:05 http://www.nakov.com 11.622",
        //                    "2014-Apr-01 02:06 http://softuni.bg 4.33",
        //                    "2014-Apr-01 02:11 http://www.google.com 1.94",
        //                    "2014-Apr-01 02:11 http://www.google.com 2.011",
        //                    "2014-Apr-01 02:12 http://www.google.com 4.882",
        //                    "2014-Apr-01 02:34 http://softuni.bg 4.885",
        //                    "2014-Apr-01 02:36 http://www.nakov.com 10.74",
        //                    "2014-Apr-01 02:36 http://www.nakov.com 11.75",
        //                    "2014-Apr-01 02:38 http://softuni.bg 3.886",
        //                    "2014-Apr-01 02:44 http://www.google.com 1.04",
        //                    "2014-Apr-01 02:48 http://www.google.com 1.4555",
        //                    "2014-Apr-01 02:55 http://www.google.com 1.977"
        //                };

        List<string[]> inputData = new List<string[]>();

        for (int i = 0; i < input.Length; i++)
        {
            string[] split = input[i].Split(' ');
            string date = split[0] + " " + split[1];
            string url = split[2];
            string seconds = split[3];
            string[] formatedData = { date, url, seconds };

            inputData.Add(formatedData);
        }

        for (int i = 0; i < inputData.Count - 1; i++)
        {
            for (int j = i + 1; j < inputData.Count; j++)
            {
                if (inputData[i][1].Equals(inputData[j][1]))
                {
                    string[] temp = inputData[j];
                    inputData.Remove(inputData[j]);
                    inputData.Insert(i + 1, temp);
                }
            }
        }

        //for (int i = 0; i < inputData.Count; i++)
        //{
        //    Console.WriteLine("{0} -> {1}", inputData[i][1], inputData[i][0]);
        //}

        float sum = 0;
        //double sum = 0;
        int count = 0;
        string check = "";

        Dictionary<string, float> result = new Dictionary<string, float>();
        //Dictionary<string, double> result = new Dictionary<string, double>();

        for (int i = 0; i < inputData.Count; i++)
        {
            string url = inputData[i][1];

            float sec = Convert.ToSingle(inputData[i][2], System.Globalization.CultureInfo.InvariantCulture);
            //double sec = Convert.ToSingle(inputData[i][2], System.Globalization.CultureInfo.InvariantCulture);

            if (!(check.Equals(url)))
            {
                sum = 0;
                count = 0;
                check = url;
            }

            sum += sec;
            count++;

            if (result.ContainsKey(url))
            {
                result[url] = (sum / count);
            }
            else
            {
                result.Add(url, sec);
            }
        }

        foreach (var item in result)
        {
            Console.WriteLine("{0} -> {1}", item.Key, item.Value);
        }
    }
}