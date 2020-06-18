using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithms.longest_substring_without_repeating_characters
{
   public class LongestSubstringWithoutRepeatingChars
    {
        public static int FindLongestSubstringWithoutRepeatingChars(string str)
        {
            int leftPointer = 0;
            int rightPointer = 0;
            int[] freDict = new int[128];

            int longest = 0;
            while (rightPointer < str.Length)
            {
                char rightValue = str[rightPointer];

                if(freDict[rightValue] > 0)
                {
                    leftPointer = Math.Max(leftPointer, freDict[rightValue]+1);
                }
                freDict[rightValue]++;

                longest = Math.Max(longest, rightPointer - leftPointer);

                rightPointer++;
            }

            return longest;
        }
    }
}
