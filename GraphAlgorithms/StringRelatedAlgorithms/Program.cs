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

            OptimizedFindLongestCommonSubsequnec();
        }

        public static void OptimizedFindLongestCommonSubsequnec()
        {
               string s1 ="elephant";
            string s2 ="eretpat";
            int len =  Optimized_LongestCommonSubsequence.OptimizedFindLongestCommonSubsequnec(s1, s2);
            Console.WriteLine(len);
        }
    }
}
