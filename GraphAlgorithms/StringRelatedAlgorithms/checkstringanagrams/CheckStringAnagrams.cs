using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRelatedAlgorithms.checkstringanagrams
{
    public class CheckStringAnagrams
    {
        static int NO_OF_CHARS = 128;

        public static bool IsStringAnagram(string s1, string s2)
        {

            if (s1.Length != s2.Length) return false;

            int[] count1 = new int[NO_OF_CHARS]; // create array of 128 length ASCII

            int[] count2 = new int[NO_OF_CHARS];

            for (int i = 0; i < s1.Length || i < s2.Length; i++)
            {
                char s1Char = s1[i];
                char s2Char = s2[i];

                count1[s1Char]++;
                count2[s2Char]++;
            }

            for (int i = 0; i < NO_OF_CHARS; i++)
            {
                if (count1[i] != count2[i]) return false;
            }

            return true;
        }
    }
}
