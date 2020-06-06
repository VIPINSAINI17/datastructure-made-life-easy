using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRelatedAlgorithms.checkstringsubsequence
{

        // Given two strings str1 and str2, find if str1 is a subsequence of str2. 
        // A subsequence is a sequence that can be derived from another sequence by deleting some elements 
        // without changing the order of the remaining elements (source: wiki). Expected time complexity is linear.

        //Examples :

        //Input: str1 = "AXY", str2 = "ADXCPY"
        //Output: True (str1 is a subsequence of str2)


        // Always start matching from right to left
        public class CheckStringSubsequence
        {
            public static bool IsSubSequence(string str1, string str2, int m, int n) 
            { 
                // Base Cases 
                if (m == 0) return true; 
                if (n == 0) return false; 
  
                // If last characters of two strings are matching 
                if (str1[m-1] == str2[n-1])
                    return IsSubSequence(str1, str2, m - 1, n - 1); 
  
                // If last characters are not matching 
                return IsSubSequence(str1, str2, m, n - 1); 
            } 
        }
}
