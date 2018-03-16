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

        /// <summary>
        /// 第五题
        /// </summary>
        /// <returns></returns>
        public bool LongestPalindrome()
        {
            string strTest1 = "babad";
            string strTest2 = "cbbd";
            string strTest3 = "a";
            string strTest4 = "civilwartestingwhetherthatnaptionoranynartionsoconceivedandsodedicatedcanlongendureWeareqmetonagreatbattlefiemldoftzhatwarWehavecometodedicpateaportionofthatfieldasafinalrestingplaceforthosewhoheregavetheirlivesthatthatnationmightliveItisaltogetherfangandproperthatweshoulddothisButinalargersensewecannotdedicatewecannotconsecratewecannothallowthisgroundThebravelmenlivinganddeadwhostruggledherehaveconsecrateditfaraboveourpoorponwertoaddordetractTgheworldadswfilllittlenotlenorlongrememberwhatwesayherebutitcanneverforgetwhattheydidhereItisforusthelivingrathertobededicatedheretotheulnfinishedworkwhichtheywhofoughtherehavethusfarsonoblyadvancedItisratherforustobeherededicatedtothegreattdafskremainingbeforeusthatfromthesehonoreddeadwetakeincreaseddevotiontothatcauseforwhichtheygavethelastpfullmeasureofdevotionthatweherehighlyresolvethatthesedeadshallnothavediedinvainthatthisnationunsderGodshallhaveanewbirthoffreedomandthatgovernmentofthepeoplebythepeopleforthepeopleshallnotperishfromtheearth";

            return helper.LongestPalindrome(strTest1) == "aba" &&
                   helper.LongestPalindrome(strTest2) == "bb" &&
                   helper.LongestPalindrome(strTest3) == "a" &&
                   helper.LongestPalindrome(strTest4) == "ranynar";
        }

        /// <summary>
        /// 第六题
        /// </summary>
        /// <returns></returns>
        public bool Convert()
        {
            string strTest1 = "PAYPALISHIRING";

            return helper.Convert(strTest1, 3) == "PAHNAPLSIIGYIR";
        }

        /// <summary>
        /// 第七题
        /// </summary>
        /// <returns></returns>
        public bool Reverse()
        {
            int test1 = 123;
            int test2 = -123;
            int test3 = 120;
            int test4 = 2147483647;
            int test5 = -2147483647;

            return helper.Reverse(test1) == 321 &&
                   helper.Reverse(test2) == -321 &&
                   helper.Reverse(test3) == 21 &&
                   helper.Reverse(test4) == 0 &&
                   helper.Reverse(test5) == 0;
        }
    }
}
