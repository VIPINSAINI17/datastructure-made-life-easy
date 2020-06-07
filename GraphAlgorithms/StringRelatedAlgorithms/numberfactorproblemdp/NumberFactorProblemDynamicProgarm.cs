using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRelatedAlgorithms.numberfactorproblemdp
{
    public class NumberFactorProblemDynamicProgarm
    {
        // Number to use 1,3,4
        public static int WaysToGetN(int n)
        {
            int[] dp = new int[n + 1];
            return WaysToGetNTopDown(dp, n);
        }//End of method


        public static int WaysToGetNTopDown(int[] dp, int n)
        {
            if ((n == 0) || (n == 1) || (n == 2)) // { }, {1}, {1,1}
                return 1;
            if (n == 3)
                return 2; // {1,1,1}, {3}

            if (dp[n] == 0)
            {
                int subtract1 = WaysToGetNTopDown(dp, n - 1);// if we subtract 1, we will be left with 'n-1'
                int subtract3 = WaysToGetNTopDown(dp, n - 3);// if we subtract 3, we will be left with 'n-3'
                int subtract4 = WaysToGetNTopDown(dp, n - 4);// if we subtract 4, we will be left with 'n-4'

                dp[n] = subtract1 + subtract3 + subtract4;
            }

            return dp[n];
        }//End of method
    }
}
