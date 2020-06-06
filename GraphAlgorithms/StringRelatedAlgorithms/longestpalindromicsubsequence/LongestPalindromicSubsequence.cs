using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRelatedAlgorithms.longestpalindromicsubsequence
{
    public class LongestPalindromicSubsequence
    {
        public static int LongestPalindromicSubseq(string s, int i, int j)
        {
            if (i == j) return 1;  // BASE CASE -1 #if both the index are at the same position then it's palinromic as it's 1 char

            if (i > j) return 0;  // BASE CASE -2 #if we traverse 1/2 strings retun 0

            int c3 =0;
            if (s[i] == s[j])
                c3 = 2 + LongestPalindromicSubseq(s, i + 1, j - 1);

            int c1 = LongestPalindromicSubseq(s, i + 1, j);

            int c2 = LongestPalindromicSubseq(s, i, j - 1);

            int longestPalindromicSub = Math.Max(c3, Math.Max(c1, c2));

            return longestPalindromicSub;
        }
    }
}
