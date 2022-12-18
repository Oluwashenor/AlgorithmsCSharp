using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCSharp
{
    public class TimeConversion
    {

        //Given a time in 12-hour AM/PM format, convert it to military(24-hour) time.
        //Note: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
        //- 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.
        
        //Function Description
        //Complete the timeConversion function in the editor below.
        //It should return a new string representing the input time in 24 hour format.
        //timeConversion has the following parameter(s):

        //string s: a time in 12 hour format
        //Returns

        //string: the time in 24 hour format

        //Sample Input  - 07:05:45PM
        //Sample Output - 19:05:45

        public static void timeConversionExecutor()
        {
            var response = timeConversion("07:05:45PM");
            Console.WriteLine(response);
        }
        protected static string timeConversion(string s)
        {
            return DateTime.Parse(s).ToString("HH:mm:ss");
        }

    }
}
