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
        public static int sockMerchant(int n, List<int> ar)
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
                            Console.WriteLine("Found {0} at {1} and {2} at {3}", ar[i], i, ar[j], j);
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
