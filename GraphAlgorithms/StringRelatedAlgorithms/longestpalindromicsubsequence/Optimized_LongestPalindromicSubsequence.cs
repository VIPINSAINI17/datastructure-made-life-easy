using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRelatedAlgorithms.longestpalindromicsubsequence
{
    public class Optimized_LongestPalindromicSubsequence
    {
        public static int LongestPalindromicSubseq(string s, int i, int j, int[,] dp)
        {
            if (i == j) return 1;  // BASE CASE -1 #if both the index are at the same position then it's palinromic as it's 1 char

            if (i > j) return 0;  // BASE CASE -2 #if we traverse 1/2 strings retun 0

            if (dp[i, j] == -1)
            {
                int c3 = 0;
                if (s[i] == s[j])
                    c3 = 2 + LongestPalindromicSubseq(s, i + 1, j - 1, dp);

                int c1 = LongestPalindromicSubseq(s, i + 1, j, dp);

                int c2 = LongestPalindromicSubseq(s, i, j - 1, dp);

                dp[i, j] = Math.Max(c3, Math.Max(c1, c2));
            }

            return dp[i, j];
        }

        public static int OptimizedFindLongestPalindromicSubseq(string s)
        {
            int[,] dp = new int[s.Length, s.Length];

            for (int row = 0; row < s.Length; row++)
                for (int col = 0; col < s.Length; col++)
                    dp[row, col] = -1;

            return LongestPalindromicSubseq(s,0, s.Length-1, dp);
        }
    }
}
