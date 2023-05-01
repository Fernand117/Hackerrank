using System;
using System.Linq;

namespace Hackerrank.Algorithms
{

    /*
     * Algoritmos BubbleSort de practica para entenderlos.
     */

    public class BubbleSort
    {
        private static int[] arr = new[] {10, 11, 15, 2, 56, 5, 7, 0, 24, 1};
        public static void BubSort()
        {
            Show();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length -i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int aux = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = aux;
                    }
                }
            }
            Show();
        }

        public static void Show()
        {
            foreach (var VARIABLE in arr)
            {
                Console.WriteLine(VARIABLE);
            }
            Console.WriteLine("\n");
        }
    }
}
