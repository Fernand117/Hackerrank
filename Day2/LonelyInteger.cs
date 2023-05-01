using System;
using System.Collections.Generic;
using System.Linq;

namespace Hackerrank.Day2
{
    class Result
    {

        /*
         * Complete the 'lonelyinteger' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY a as parameter.
         */

        public static int lonelyinteger(List<int> a, int n)
        {
            int elementLonely = 0;
            int currentElement = 0;
            int count = 0;

            a.Sort(0, n, null);

            if (n >= 1 && n <= 100)
            {
                for (int i = 0; i < n; i++)
                {
                    if (a[i] >= 0 && a[i]<= 100)
                    {
                        if (a[i] == currentElement)
                        {
                            count++;
                        }
                        else
                        {
                            if (count == 1 || (i + 1) == n)
                            {
                                if (currentElement != 0 && count == 1)
                                {
                                    elementLonely = currentElement;
                                }
                                else
                                {
                                    elementLonely = a[i];
                                }
                            }

                            currentElement = a[i];
                            count = 1;
                        }
                    }
                }
            }

            return elementLonely;
        }

    }
    
    public class LonelyInteger
    {
        public static void MainLI(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH")!, true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = Result.lonelyinteger(a, n);
            Console.WriteLine(result);
            /*textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();*/
        }
    }
}
