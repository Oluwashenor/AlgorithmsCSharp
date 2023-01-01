using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCSharp
{
	public class DiagonalDifference
	{
		public static int diagonalDifference(List<List<int>> arr)
		{
			int pd = 0;
			int sd = 0;
			int length = arr.Count;
			int index = 0;
			int sdIndex = arr.Count;

			while (index < length)
			{
				pd = pd + arr[index][index];
				sd = sd + arr[index][sdIndex - 1];
				index = index + 1;
				sdIndex = sdIndex - 1;
			}
			return Math.Abs(pd - sd);
		}

	}
}
