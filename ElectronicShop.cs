using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCSharp
{
    public class ElectronicShop
    {
        //A person wants to determine the most expensive computer keyboard
        //and USB drive that can be purchased with a give budget.
        //Given price lists for keyboards and USB drives and a budget,
        //find the cost to buy them. If it is not possible to buy both items
        //return -1.

        //b = 60;
        //keyboards = ['40','50','60'];
        //drives = [5,8,12];
        //the person can buy a 40 keyboard and 12 drive and equal 52, and also can buy 50 keyboard 
        //and 8 drives, so return 58, since its the highest that can be highest.
        //
        //Returns
        //int: the maximum that can be spent, or -1 if it is not possible to buy both items
        public static void ElectronicShopExecutor()
        {
            int b = 60;  
            int[] keyboards = new int[] { 40, 50, 60 };
            int[] drives = new int[] { 5, 8, 12 };
            int result = getMoneySpent(keyboards, drives, b);
            Console.WriteLine(result);
        }



        private static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            /*
             * Write your code here.
             */

            int max = -1;

            foreach (var k in keyboards)
            {
                if (k < b)
                {
                    foreach (var d in drives)
                    {
                        int sum = d + k;
                        if (sum <= b)
                        {
                            if (max < sum) max = sum;  
                        }
                    }
                }
            }
            return max;

        }

    }
}
