using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRelatedAlgorithms.longestpalindromicsubstring
{
    public class Optimized_LongestPalindromicSubstring
    {
        public static int LongestPalindromicSubstr(string s, int i, int j, int[,] dp)
        {
            if (i == j) return 1;  // BASE CASE -1 #if both the index are at the same position then it's palinromic as it's 1 char

            if (i > j) return 0;  // BASE CASE -2 #if we traverse 1/2 strings retun 0

            int c3 = 0;

            if (dp[i, j] == -1)
            {
                if (s[i] == s[j])
                {
                    int remailingLength = (j - 1) - i;

                    if (remailingLength == LongestPalindromicSubstr(s, i + 1, j - 1, dp))
                        c3 = remailingLength + 2;
                }

                int c1 = LongestPalindromicSubstr(s, i + 1, j, dp);

                int c2 = LongestPalindromicSubstr(s, i, j - 1, dp);

                dp[i, j] = Math.Max(c3, Math.Max(c1, c2));
            }

            return dp[i, j];
        }

        public static int OptimizedLongestPalindromicSubstr(string s)
        {
            int[,] dp = new int[s.Length, s.Length];

            for (int row = 0; row < s.Length; row++)
                for (int col = 0; col < s.Length; col++)
                    dp[row, col] = -1;

            return LongestPalindromicSubstr(s, 0, s.Length - 1, dp);
        }
    }
}
