using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRelatedAlgorithms.longtestcommonsubsequence
{
    public class Optimized_LongestCommonSubsequence
    {
        private static int FindLongestCommonSubsequnec(string s1, string s2, int i1, int i2, int[,] dp)
        {
            if (i1 == s1.Length || i2 == s2.Length) return 0;


            if (dp[i1, i2] == -1)
            {
                if (s1[i1] == s2[i2])
                {
                    dp[i1, i2] = 1 + FindLongestCommonSubsequnec(s1, s2, i1 + 1, i2 + 1, dp);
                return dp[i1, i2];
                }
                else{
                
                int c1 = FindLongestCommonSubsequnec(s1, s2, i1 + 1, i2, dp);

                int c2 = FindLongestCommonSubsequnec(s1, s2, i1, i2 + 1, dp);

                dp[i1, i2] = Math.Max(c1, c2);
                
                }
            }


            return dp[i1, i2];
        }

        public static int OptimizedFindLongestCommonSubsequnec(string s1, string s2)
        {
            int[,] dp = new int[s1.Length, s2.Length];

            for (int row = 0; row < s1.Length; row++)
                for (int col = 0; col < s2.Length; col++)
                    dp[row, col] = -1;

            return FindLongestCommonSubsequnec(s1, s2, 0, 0, dp);
        }
    }

    
}
