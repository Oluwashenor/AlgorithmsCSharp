using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCSharp
{
    public class RecursiveDigitSum
    {
        public static int superDigit(string n, int k)
        {
            int superD = mySuperDigit(n, k);
            Console.WriteLine(superD);
            return superD;
        }

        public static int mySuperDigit(string value, int k)
        {
            BigInteger sum = 0;
            for (int i = 0; i< value.Length; i++)
            {
                int x = k * Convert.ToInt32(value[i].ToString());
                 sum = sum + x;  

            }
            if (sum > 10) { sum =  mySuperDigit(sum.ToString(), 1); }
            return (int)sum;
        }

    }

}
