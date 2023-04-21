using System.Collections.Generic;
using System.Linq;
using System;

namespace Hackerrank
{
    class ResultPM
    {
        public static void plusMinus(List<int> arr, int n)
        {
            int neg = 0;
            int pos = 0;
            int cero = 0;

            for(int i = 0; i < n; i++)
            {
                if (0 < n && n <= 100)
                {
                    if (arr[i] > 0 && arr[i] < 100)
                    {
                        pos++;
                    }
                    if (-100 <= arr[i] && arr[i] <= -1)
                    {
                        neg++;
                    }
                    else if (arr[i] == 0)
                    {
                        cero++;
                    }
                }
            }

            float negr = (float)neg / n;
            float posr = (float)pos / n;
            float ceror = (float)cero / n;

            Console.WriteLine(posr.ToString("F6") + "\n" + negr.ToString("F6") + "\n" + ceror.ToString("F6"));
        }
    }

    class PlusMinus
    {
        public static void PlusMinusMain(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            ResultPM.plusMinus(arr, n);
        }
    }

}
