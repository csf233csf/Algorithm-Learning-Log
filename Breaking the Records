// https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the breakingRecords function below.
    static int[] breakingRecords(int[] scores)
    {
        int min = scores[0], max = scores[0];
        int highestCount = 0, lowestCount = 0;
        for (int i = 1; i < scores.Count(); i++)
        {
            if (max < scores[i])
            {
                max = scores[i];
                highestCount++;
            }
            else if (min > scores[i])
            {
                min = scores[i];
                lowestCount++;
            }
        }
        return new int[] { highestCount, lowestCount };
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
        ;
        int[] result = breakingRecords(scores);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
