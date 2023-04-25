using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Hackerrank
{
    class Result
    {

        /*
         * Complete the 'findMedian' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static int findMedian(List<int> arr, int n)
        {
            int middle = 0;
            if (n >= 1 && n <= 1000001)
            {
                Array.Sort(arr.ToArray());
                middle = arr[(arr.ToArray().Length - 1) / 2];
            }
            return middle;
        }

    }
    public class FindMedian
    {
        public static void MainFindMedian(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = Result.findMedian(arr, n);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}