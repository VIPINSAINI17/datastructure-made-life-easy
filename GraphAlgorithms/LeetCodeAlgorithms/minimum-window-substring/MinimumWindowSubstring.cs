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
        public static List<string> FindAllMinimumWindowSubstring(string source, string target)
        {

            Dictionary<char, int> charFrequency = new Dictionary<char, int>();
            List<string> minWindowList = new List<string>();
            int maxValue = int.MaxValue;

            foreach (var c in target)
            {
                if (charFrequency.ContainsKey(c))
                    charFrequency[c] = charFrequency[c] + 1;
                else
                    charFrequency.Add(c, 1);

            }

            int rightPointer = 0;
            int leftPointer = 0;
            int length = source.Length;
            int counter = target.Length;

            while (rightPointer < length)
            {
                char rightValue = source[rightPointer];

                if (charFrequency.ContainsKey(rightValue))
                    charFrequency[rightValue] = charFrequency[rightValue] - 1;
                continue;
                
                if (charFrequency[rightValue] == 0) counter--;
                rightPointer++;

                while (counter == 0)
                {
                    char leftValue = source[leftPointer];

                    if (charFrequency.ContainsKey(leftValue))
                        charFrequency[leftValue] = charFrequency[leftValue] + 1;

                    if (charFrequency[leftValue] == 1) counter++;

                    int sizeOfSubstring = rightPointer - leftPointer;
                    if (sizeOfSubstring < maxValue)
                    {
 
                        string minWindowSubstring = source.Substring(leftPointer, sizeOfSubstring);
                        minWindowList.Add(minWindowSubstring);
                    }
                    leftPointer++;
                }
            }
            return minWindowList;
        }
    }
}
