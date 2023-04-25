using System;
using System.Globalization;
using System.IO;

namespace Hackerrank
{
    class ResultT
    {

        /*
         * Complete the 'timeConversion' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING s as parameter.
         */

        public static string timeConversion(string s)
        {
            string hora24h = DateTime.ParseExact(s, "hh:mm:sstt", CultureInfo.InvariantCulture).ToString("HH:mm:ss");
            //string hora24str = hora24h.ToString("HH:mm:ss zz");
            Console.WriteLine(hora24h);
            return hora24h;
        }

    }

    public class TimeConversion
    {
        public static void MainT(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = ResultT.timeConversion(s);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}