using System;

namespace Hackerrank
{
    public class MockTest
    {
        public static void fizzBuzz(int n)
        {
            if (n > 0 && n < 2 * Math.Pow(10, 5))
            {
                for (int i = 1; i < n + 1; i++)
                {
                    if ((i % 3) == 0 && (i % 5) == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if ((i % 3) == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if ((i % 5) == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }

    public class SolMock
    {
        public static void MainMock(string[] arg)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            MockTest.fizzBuzz(n);
        }
    }
}