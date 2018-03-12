using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            TestTools helper = new TestTools();

            //第一题
            Console.WriteLine("第一题");
            Console.WriteLine(helper.TwoSum());

            //第三题
            Console.WriteLine("第二题");
            Console.WriteLine(helper.LengthOfLongestSubstring());

            //第五题
            Console.WriteLine("第五题");
            Console.WriteLine(helper.LongestPalindrome());

            //第六题
            Console.WriteLine("第六题");
            Console.WriteLine(helper.Convert());

            Console.ReadKey();
        }
    }
}
