using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRelatedAlgorithms.housetheifproblem
{
    //    Find maximum possible stolen value from houses 
    //    There are n houses build in a line, each of which contains some value in it. 
    //    A thief is going to steal the maximal value of these houses, 
    //    but he can’t steal in two adjacent houses because the owner of the stolen houses will tell his two neighbours left and right side. 
    //    What is the maximum stolen value?

    //      Examples:

    //      Input: hval[] = {6, 7, 1, 3, 8, 2, 4}
    //      Output: 19

    //      Explanation: The thief will steal 6, 1, 8 and 4 from the house.

    //      Input: hval[] = {5, 3, 4, 11, 2}
    //      Output: 16

    //Explanation: Thief will steal 5 and 11
    public class HouseTheifProblemDP
    {
        public static int maxMoney(int[] HouseNetWorth) {
		int[] dp = new int[HouseNetWorth.Length];
		return maxMoney_TopDown(dp, HouseNetWorth, 0);
	}


        private static int maxMoney_TopDown(int[] dp, int[] HouseNetWorth, int currentIndex)
        {
            if (currentIndex >= HouseNetWorth.Length)
                return 0;

            if (dp[currentIndex] == 0)
            {
                int skipCurrent = maxMoney_TopDown(dp, HouseNetWorth, currentIndex + 1); // Skip current house means currentIndex increase by 1

                int stealCurrent = HouseNetWorth[currentIndex] + maxMoney_TopDown(dp, HouseNetWorth, currentIndex + 2);
     
                dp[currentIndex] = Math.Max(stealCurrent, skipCurrent);
            }
            return dp[currentIndex];
        }
    }
}
