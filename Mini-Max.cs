using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCSharp
{
	public class Mini_Max
	{

		/// <summary>
		/// Function Description
		//Complete the miniMaxSum function in the editor below.
		//miniMaxSum has the following parameter(s) :
		//arr: an array of 5 integers
		//Print
		//Print two space-separated integers on one line: the minimum sum and the maximum sum of 1 of 5 elements.
		//Example
		//arr = [1, 3, 5, 7, 9]
		//The minimum sun is 1 + 3 + 5 + 7 = 16 and the maximum sum is
		//3 + 5 + 7 + 9 = 24. The function prints

		//Explanation
		//The numbers are 1, 2, 3, 4, and 5. Calculate the following sums using four of the five integers:
		//1. Sum everything except 1, the sum is 2 + 3 + 4 + 5 = 14
		//2. Sum everything except 2, the sum is 1 + 3 + 4 + 5 = 13.
		//3. Sum everything except 3, the sum is 1 + 2 + 4 + 5 = 12.
		//4. Sum everything except 4, the sum is 1 + 2 + 3 + 5 = 11.
		//5. Sum everything except 5, the sum is 1 + 2 + 3 + 4 = 10
		//Hints: Beware of integer overflow! Use 64-bit Integer.
		//Need help to get started? Try the Solve Me First problem
		//
		//


		public static void Mini_MaxExecutor()
		{
			List<int> list = new List<int>();
			list = new List<int> { 1, 2, 3, 4, 5 };
			List<int> list2 = new List<int>();
			list2 = new List<int> { 501893267, 649027153, 379408215, 452968170, 487530619 };
			miniMaxSum(list2);
		}

		protected static void miniMaxSum(List<int> arr)
		{
			List<long> listme = new List<long>();
			for (int i = 0; i < arr.Count; i++)
			{
				long sum = 0;
				foreach (var n in arr)
				{
					sum = sum + n;
				}
				sum = sum - arr[i];
				listme.Add(sum);
			}
			long max = listme.Max();
			long min = listme.Min();
			Console.WriteLine("{0} {1}", min, max);
		}
	}
}
