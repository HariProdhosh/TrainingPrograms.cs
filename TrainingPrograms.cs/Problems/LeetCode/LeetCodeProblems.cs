using Microsoft.VisualStudio.TestPlatform.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.DevTools.V125.Network;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TrainingPrograms.cs.Problems.LeetCode
{
    public class LeetCodeProblems
    {
        /// <summary>
        /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
        ///
        /// You can return the answer in any order.
        ///
        ///
        ///
        /// Example 1:
        ///
        /// Input: nums = [2, 7, 11, 15], target = 9
        ///         Output: [0, 1]
        ///         Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
        /// Example 2:
        ///
        ///         Input: nums = [3, 2, 4], target = 6
        ///         Output: [1, 2]
        /// Example 3:
        ///
        ///         Input: nums = [3, 3], target = 6
        ///         Output: [0, 1]
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return null;
        }

        //public List AddTwoNumbers(ListNode l1, ListNode l2)
        //{
        //    List<int> res = new();
        //    if (l1.length == l2.length)
        //    {
        //        int rem = 0;
        //        for (int i = 0; i < l1.length; i++)
        //        {
        //            int abc = l1[i] + l2[i];
        //            if (abc > 9)
        //            {
        //                string ss=abc.ToString();
        //                res.Add(int.Parse(ss));
        //                continue;
        //            }
        //            else
        //            {
        //                res.Add(abc);
        //            }
        //        }
        //    }
        //    return null;
        //}
    }
}