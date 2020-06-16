using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithms.find_all_anagrams_in_a_string
{
        // 438- Given a string s and a non-empty string p, find all the start indices of p's anagrams in s.

        //  Strings consists of lowercase English letters only and the length of both strings s and p will not be larger than 20,100.

        //  The order of output does not matter.

        //  Example 1:

        //  Input:
        //  s: "cbaebabacd" p: "abc"

        //  Output:
        //  [0, 6]

        //  Explanation:
        //  The substring with start index = 0 is "cba", which is an anagram of "abc".
        //  The substring with start index = 6 is "bac", which is an anagram of "abc".
        //  Example 2:

        //  Input:
        //  s: "abab" p: "ab"

        //  Output:
        //  [0, 1, 2]

        //  Explanation:
        //  The substring with start index = 0 is "ab", which is an anagram of "ab".
        //  The substring with start index = 1 is "ba", which is an anagram of "ab".
        //  The substring with start index = 2 is "ab", which is an anagram of "ab".
    public class FindAllAnagrams
    {

        public static List<string> AllAnagrams(string source, string target)
        {

            Dictionary<char, int> charFrequency = new Dictionary<char, int>();
            List<string> anagramsList = new List<string>();

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
                if (charFrequency[rightValue] == 0) counter--;
                rightPointer++;

                while (counter == 0)
                {
                    char leftValue = source[leftPointer];

                    if (charFrequency.ContainsKey(leftValue))
                        charFrequency[leftValue] = charFrequency[leftValue] + 1;

                    if (charFrequency[leftValue] == 1) counter++;

                    if (rightPointer - leftPointer == target.Length)
                    {
                        string anagram = source.Substring(leftPointer, rightPointer - leftPointer);
                        anagramsList.Add(anagram);
                    }
                    leftPointer++;
                }
            }
            return anagramsList;
        }
    }
}
