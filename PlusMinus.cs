using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCSharp
{
    public class PlusMinus
    {

        // Given an array of integers, calculate the ratios of its elements that
        // are positive, negative, and zero.Print the decimal value of each fraction
        // on a new line with 6 places after the decimal.

        // arr[] size n = 6
        // arr = [-4, 3, -9, 0, 4, 1]

        //0.500000
        //0.333333
        //0.166667

        //There are 3 positive numbers,2 negative numbers, and 1 zero in the array.

        public static void plusMinusExecutor()
        {
            //Create a list of integers
            List<int> list = new List<int>();
            list = new List<int>{ -4, 3, -9, 0, 4, 1};
            plusMinus(list);
        }

        protected static void plusMinus(List<int> arr)
        {
            int negatives = 0;
            int positives = 0;
            int zeros = 0;
            foreach (var n in arr)
            {
                if (n < 0)
                {
                    negatives = negatives + 1;
                }
                if (n == 0)
                {
                    zeros = zeros + 1;
                }
                if (n > 0)
                {
                    positives = positives + 1;
                }
            }
            decimal a = Math.Round(Decimal.Divide(positives, arr.Count), 6);
            decimal b = Math.Round(Decimal.Divide(negatives , arr.Count), 6);
            decimal c = Math.Round(Decimal.Divide(zeros, arr.Count), 6);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }

    }
}
