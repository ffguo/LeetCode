using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LeetTools
    {
        /// <summary>
        /// 第一题
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dic.ContainsKey(nums[i]))
                    dic.Add(nums[i], i);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                int complementValue = 0;
                bool isHasValue = dic.TryGetValue(complement, out complementValue);
                if (dic.ContainsKey(nums[i]) && isHasValue && complementValue != i)
                {
                    return new int[] { i, dic[complement] };
                }
            }
            throw new Exception("No two sum solution");
        }

        /// <summary>
        /// 第三题
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int LengthOfLongestSubstring(string s)
        {
            int n = s.Length;
            int ans = 0, i = 0, j = 0;
            HashSet<char> set = new HashSet<char>();
            while (i < n && j < n)
            {
                if (!set.Contains(s[j]))
                {
                    set.Add(s[j++]);
                    ans = Math.Max(ans, j - i);
                }
                else
                {
                    set.Remove(s[i++]);
                }
            }
            return ans;
        }

        /// <summary>
        /// 第五题
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string LongestPalindrome(string s)
        {
            int start = 0, end = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int len1 = expandAroundCenter(s, i, i);
                int len2 = expandAroundCenter(s, i, i + 1);
                int len = Math.Max(len1, len2);
                if (len > end - start)
                {
                    start = i - (len - 1) / 2;
                    end = i + len / 2;
                }
            }
            return s.Substring(start, end - start + 1);
        }

        private int expandAroundCenter(String s, int left, int right)
        {
            int L = left, R = right;
            while ((L >= 0 && R < s.Length) && (s[L] == s[R]))
            {
                L--;
                R++;
            }
            return R - L - 1;
        }

        /// <summary>
        /// 第六题
        /// </summary>
        /// <param name="s"></param>
        /// <param name="numRows"></param>
        /// <returns></returns>
        public string Convert(string s, int numRows)
        {
            int i = 0;
            string[] arr = new string[numRows];
            while (i < s.Length)
            {
                for (int j = 0; j < numRows && i < s.Length; j++)
                {
                    arr[j] += s[i++];
                }
                for (int j = numRows - 2; j >= 1 && i < s.Length; j--)
                {
                    arr[j] += s[i++];
                }
            }
            return string.Join("", arr);
        }

        /// <summary>
        /// 第七题:解法一
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int Reverse(int x)
        {
            int result = 0;
            string tmp = string.Join("", x.ToString().Reverse());
            if (tmp[tmp.Length - 1] == '-')
            {
                return int.TryParse(tmp.Substring(0, tmp.Length - 1), out result) ? -result : 0;
            }
            else
            {
                return int.TryParse(tmp, out result) ? result : 0;
            }
        }

        /// <summary>
        /// 第七题:解法二
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int Reverse1(int x)
        {
            int result = 0;
            if (x == 0)
                return 0;
            while (x != 0)
            {
                if (result > (2147483647 / 10) || result < (-2147483648 / 10))
                    return 0;
                result = result * 10 + x % 10;
                x /= 10;
            }
            return result;
        }
    }
}
