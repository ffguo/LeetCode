using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TestTools
    {
        private LeetTools helper = new LeetTools();

        /// <summary>
        /// 第一题
        /// </summary>
        /// <returns></returns>
        public bool TwoSum()
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            int[] results = helper.TwoSum(nums, target);

            return (results[0] == 0 && results[1] == 1);
        }

        /// <summary>
        /// 第三题
        /// </summary>
        /// <returns></returns>
        public bool LengthOfLongestSubstring()
        {
            string strTest1 = "abcabcbb";
            string strTest2 = "bbbbb";
            string strTest3 = "pwwkew";

            return helper.LengthOfLongestSubstring(strTest1) == 3 &&
                   helper.LengthOfLongestSubstring(strTest2) == 1 &&
                   helper.LengthOfLongestSubstring(strTest3) == 3;
        }
    }
}
