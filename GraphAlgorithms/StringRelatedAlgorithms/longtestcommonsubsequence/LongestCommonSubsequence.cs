using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRelatedAlgorithms.longtestcommonsubsequence
{
    public class LongestCommonSubsequence
    {

        public static int FindLongestCommonSubsequnec(string s1, string s2, int i1, int i2)
        {
            if (i1 == s1.Length || i2 == s2.Length) return 0;

            int c3 = 0;
            if (s1[i1] == s2[i2])
                c3 = 1 + FindLongestCommonSubsequnec(s1, s2, i1 + 1, i2 + 1);

            int c1 = FindLongestCommonSubsequnec(s1, s2, i1 + 1, i2);

            int c2 = FindLongestCommonSubsequnec(s1, s2, i1, i2+1);

            int longestSusequence = Math.Max(c3, Math.Max(c1,c2));

            return longestSusequence;
        }
    }
}
