using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithms.ArrayAlgorithms.length_of_smallest_subarray_with_sum_greater_number
{
    /// <summary>
    /// 
    /// This problem can be solved with Sliding Window
    /// </summary>
    public class SmallestSubarrayGreater
    {
        // Function to find the length of smallest subarray whose sum
        // of elements is greater than the given number
        public static int smallestSubarray(int[] A, int k)
        {
            // stores the current window sum
            int windowSum = 0;

            // stores the result
            int len = int.MaxValue;

            // stores window's starting index
            int left = 0;

            // maintain a sliding window [left..right]
            for (int right = 0; right < A.Length; right++)
            {
                // include current element in the window
                windowSum += A[right];

                // window becomes unstable if its sum becomes more than k
                while (windowSum > k && left <= right)
                {
                    // update the result if current window's length is less
                    // than minimum found so far
                    len = Math.Min(len, right - left + 1);

                    // remove elements from the window's left side till window
                    // becomes stable again
                    windowSum -= A[left];
                    left++;
                }
            }

            // return result
            return len;
        }
    }
}
