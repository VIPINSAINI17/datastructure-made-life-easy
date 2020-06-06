using StringRelatedAlgorithms.checkstringanagrams;
using StringRelatedAlgorithms.checkstringpermutation;
using StringRelatedAlgorithms.checkstringsubsequence;
using StringRelatedAlgorithms.longestpalindromicsubsequence;
using StringRelatedAlgorithms.longestpalindromicsubstring;
using StringRelatedAlgorithms.longtestcommonsubsequence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRelatedAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s1 ="elephant";
            //string s2 ="eretpat";
            //int len = LongestCommonSubsequence.FindLongestCommonSubsequnec(s1, s2, 0, 0);

            //Console.WriteLine(len);

            //OptimizedFindLongestCommonSubsequnec();

            //LongestPalindromicSubseq();

            //OptimizedLongestPalindromicSubseq();

            // LongestPalindromicSubstringTest();

            //OptimizedLongestPalindromicSubstringTest();

            //IsStringPermutationTest();

            //IsStringAnagramTest();

            IsSubSequenceTest();
        }

        public static void OptimizedFindLongestCommonSubsequnec()
        {
               string s1 ="elephant";
            string s2 ="eretpat";
            int len =  Optimized_LongestCommonSubsequence.OptimizedFindLongestCommonSubsequnec(s1, s2);
            Console.WriteLine(len);
        }

        public static void LongestPalindromicSubseq()
        {
            string s1 = "ELRMENMET";
            string s2 = "eretpat";
            int len = LongestPalindromicSubsequence.LongestPalindromicSubseq(s1, 0,s1.Length-1);
            Console.WriteLine(len);
        }

        public static void OptimizedLongestPalindromicSubseq()
        {
            string s1 = "ELRMENMET";
            int len = Optimized_LongestPalindromicSubsequence.OptimizedFindLongestPalindromicSubseq(s1);
            Console.WriteLine(len);
        }

        public static void LongestPalindromicSubstringTest()
        {
            string s = "ABCCBUA";
            int len = LongestPalindromicSubstring.LongestPalindromicSubstr(s,0, s.Length-1);
            Console.WriteLine(len);
        }

        public static void OptimizedLongestPalindromicSubstringTest()
        {
            string s = "ABCCBUA";
            int len = Optimized_LongestPalindromicSubstring.OptimizedLongestPalindromicSubstr(s);
            Console.WriteLine(len);
        }

        public static void IsStringPermutationTest()
        {
            string s = "ABCCBUA";
            bool len = CheckStringPermutation.IsStringPermutation("xyz","bca");
            Console.WriteLine(len);
        }

        public static void IsStringAnagramTest()
        {
            bool len = CheckStringAnagrams.IsStringAnagram("ab", "ba");
            Console.WriteLine(len);
        }

        public static void IsSubSequenceTest()
        {
            //Input: str1 = "AXY", str2 = "ADXCPY"
            bool len = CheckStringSubsequence.IsSubSequence("AXY", "ADXCPY", "AXY".Length, "ADXCPY".Length);
            Console.WriteLine(len);
        }
    }
}
