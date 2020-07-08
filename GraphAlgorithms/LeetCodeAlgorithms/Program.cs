using LeetCodeAlgorithms.ArrayAlgorithms.length_of_smallest_subarray_with_sum_greater_number;
using LeetCodeAlgorithms.find_all_anagrams_in_a_string;
using LeetCodeAlgorithms.longest_substring_without_repeating_characters;
using LeetCodeAlgorithms.minimum_window_substring;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //FindAllAnagrams.AllAnagrams("abab", "ab");

            //MinimumWindowSubstring.FindAllMinimumWindowSubstring("ADOBECODEBANC", "ABC");

            //LongestSubstringWithoutRepeatingChars.FindLongestSubstringWithoutRepeatingChars("pwwkew");

            Program.SmallestSubArray();
        }

        public static void SmallestSubArray()
        {
            // array of positive numbers
            int[] A = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int k = 21;

            // find length of the smallest sub-array
            int len = SmallestSubarrayGreater.smallestSubarray(A, k);

            if (len != int.MaxValue )
            {
                Console.WriteLine("Smallest sub-array length is " + len);
            }
            else
            {
                Console.WriteLine("No sub-array exists");
            }
        }
    }
}
