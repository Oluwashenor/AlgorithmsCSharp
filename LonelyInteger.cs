using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCSharp
{
	public class LonelyInteger
	{

		public static void LonelyintegerExecutor()
		{
			List<int> list = new List<int>();
			list = new List<int>(){ 0, 0, 1, 2, 1 };
			int lonelyInt = lonelyinteger(list);
			Console.WriteLine("The Lonely integer is {0}",lonelyInt);
		}
		private static int lonelyinteger(List<int> a)
		{
			int lonely = default;
			List<int> partners = new List<int>();

			for (var i = 0; i < a.Count; i++)
			{
				if (partners.Contains(a[i]))
				{
					continue;
				}
				for (var j = i + 1; j < a.Count; j++)
				{
					if (j == a.Count) continue;
					if (a[i] == a[j])
					{
						partners.Add(a[i]);
					}

				}
			}
			lonely = a.Except(partners).FirstOrDefault();
			return lonely;
		}
	}
}
