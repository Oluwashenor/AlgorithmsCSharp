using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

// There is a large pile of socks that must be paired by color.
// Given an array of integers representing the color of each sock,
// determine how many pairs of socks with matching colors there are.
// n = 7
// ar = [1,2,1,2,1,3,2]
//There is one pair of color 1 and one of color 2. There are three odd socks left, one of each color. The number of pairs is 2.

//Function Description

//Complete the sockMerchant function in the editor below.

//sockMerchant has the following parameter(s):

//int n: the number of socks in the pile
///int ar[n]: the colors of each sock
//Returns

//int: the number of pairs

namespace AlgorithmsCSharp
{
    public class SockMerchant
    {

        public static void sockMerchantExecutor()
        {
            List<int> ar = new List<int> { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            List<int> arr = new List<int> { 50, 49, 38, 49, 78, 36, 25, 96,
                10, 67, 78, 58, 98, 8, 53, 1, 4, 7, 29, 6, 59, 93, 74, 3, 67,
                47, 12, 85, 84 ,40 ,81 ,85 ,89,70, 33, 66, 6,
                9, 13, 67 ,75 ,42, 24 ,73 ,49 ,28, 25, 5 ,86, 53, 10,
                44 ,45, 35, 47, 11, 81, 10, 47, 16, 49, 79, 52, 89,
                100, 36, 6, 57, 96,18, 23, 71, 11, 99, 95, 12, 78, 19,
                16, 64, 23, 77, 7, 19, 11, 5, 81, 43, 14, 27, 11, 63,
                57, 62, 3, 56, 50, 9, 13, 45 };
            int validPair = sockMerchant(5, arr);
            Console.WriteLine(validPair);
        }
        protected static int sockMerchant(int n, List<int> ar)
        {
            int pairCounter = 0;
            var taken = new List<int>();
            for (var i = 0; i < ar.Count; i++)
            {
                if (i == (ar.Count - 1)) break;
                for (var j = i + 1; j < ar.Count; j++)
                {
                    if (taken.Contains(j) || taken.Contains(i))
                    {

                    }
                    else
                    {
                        if (ar[i] == ar[j])
                        {
                            ///for Debugging
                            //Console.WriteLine("Found {0} at {1} and {2} at {3}", ar[i], i, ar[j], j);
                            pairCounter = pairCounter + 1;
                            taken.Add(i);
                            taken.Add(j);
                            break;
                        };
                    }



                }
            }
            return pairCounter;
        }
    }
}
