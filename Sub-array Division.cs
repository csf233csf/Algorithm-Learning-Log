// https://www.hackerrank.com/challenges/the-birthday-bar



using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

class Solution
{

    // Complete the birthday function below.
    static int birthday(List<int> s, int d, int m, int n)
    {
        int sum = 0;

        int result = 0;

        int v = 0;


        for (int i = 0; i < n - m + 1; i++)
        {

            for (int f = 0; f < m; f++)
            {
                v = f + i;
                sum += s[v];
            }

            if (sum == d)
            {
                result++;
                sum = 0;
                v = 0;
            }
            else
            {
                sum = 0;
                v = 0;
                continue;
            }

        }

        return result;



    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

        string[] dm = Console.ReadLine().TrimEnd().Split(' ');

        int d = Convert.ToInt32(dm[0]);

        int m = Convert.ToInt32(dm[1]);

        int result = birthday(s, d, m, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

