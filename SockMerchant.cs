using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                for (var j = i + 1; j < ar.Count; j++)
                {
                    if (taken.Contains(j) || taken.Contains(i))
                    {
                        break;
                    }
                    else
                    {
                        if (ar[i] == ar[j])
                        {
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
