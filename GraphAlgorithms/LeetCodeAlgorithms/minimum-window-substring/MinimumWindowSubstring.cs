using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithms.minimum_window_substring
{
    //  Given a string S and a string T, 
    //  find the minimum window in S which will contain all the characters in T in complexity O(n).

    //  Example:

    //  Input: S = "ADOBECODEBANC", T = "ABC"
    //  Output: "BANC"
    //  Note:

    //  If there is no such window in S that covers all characters in T, return the empty string "".
    //  If there is such window, you are guaranteed that there will always be only one unique minimum window in S.
    public class MinimumWindowSubstring
    {
        public static string FindAllMinimumWindowSubstring(string source, string target)
        {

            int[] freDict = new int[128];
            List<string> minWindowList = new List<string>();
            int minValue = int.MaxValue;
            string minWindowSubstring = string.Empty;
            foreach (var c in target)
            {
                freDict[c]++;
            }

            int rightPointer = 0;
            int leftPointer = 0;
            int length = source.Length;
            int counter = target.Length;

            while (rightPointer < length)
            {
                char rightValue = source[rightPointer];

                if (freDict[rightValue] > 0)
                {
                    counter--;
                }

                freDict[rightValue]--;

                rightPointer++;

                while (counter == 0)
                {
                    char leftValue = source[leftPointer];

                    freDict[leftValue]++;

                    if (freDict[leftValue] > 0) counter++;

                    int sizeOfSubstring = rightPointer - leftPointer;

                    if (sizeOfSubstring < minValue)
                    {

                        minValue = sizeOfSubstring;
                        minWindowSubstring = source.Substring(leftPointer, sizeOfSubstring);
                        //minWindowList.Add(minWindowSubstring);
                    }
                    leftPointer++;
                }
            }
            return minWindowSubstring;
        }
    }
}
