using System.Collections.Generic;
using System.Linq;
using System;

namespace Hackerrank
{
    class ResultMMS
    {

        /*
         * Complete the 'miniMaxSum' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void miniMaxSum(List<int> arr)
        {
            long sum = arr.Sum(x => (long)x);
            long minSum = sum - arr.Max();
            long maxSum = sum - arr.Min();

            if (maxSum > Math.Pow(10, 9))
            {
                maxSum = sum - arr.Min();
            }

            if (minSum > Math.Pow(10, 9))
            {
                minSum = sum - arr.Max();
            }

            Console.WriteLine(minSum + " " + maxSum);
        }

    }

    class MiniMaxSum
    {
        public static void MiniMaxSumMain(string[] args)
        {

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            ResultMMS.miniMaxSum(arr);
        }
    }
}