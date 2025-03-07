using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPracticeTest.LeetCode
{
    /// <summary>
    /// 189. 轮转数组<br/>
    ///    给定一个整数数组 nums，将数组中的元素向右轮转 k 个位置，其中 k 是非负数。<br/>
    ///  <br/>
    /// 示例 1:
    /// <br/>
    /// 输入: nums = [1, 2, 3, 4, 5, 6, 7], k = 3<br/>
    /// 输出: [5, 6, 7, 1, 2, 3, 4]<br/>
    /// 解释:<br/>
    /// 向右轮转 1 步: [7, 1, 2, 3, 4, 5, 6]<br/>
    /// 向右轮转 2 步: [6, 7, 1, 2, 3, 4, 5]<br/>
    /// 向右轮转 3 步: [5, 6, 7, 1, 2, 3, 4]<br/>
    ///  <br/>
    /// 示例 2:<br/>
    ///  <br/>
    /// 输入：nums = [-1,-100,3,99], k = 2<br/>
    /// 输出：[3, 99, -1, -100]<br/>
    /// 解释: <br/>
    /// 向右轮转 1 步: [99, -1, -100, 3]<br/>
    /// 向右轮转 2 步: [3, 99, -1, -100]<br/>
    ///  <br/>
    /// 提示：<br/>
    /// 1 &lt;= nums.length &lt;= 105<br/>
    ///     -231 &lt;= nums[i] &lt;= 231 - 1<br/>
    /// 0 &lt;= k &lt;= 105<br/>
    ///  <br/>
    /// 进阶：<br/>
    /// 尽可能想出更多的解决方案，至少有 三种 不同的方法可以解决这个问题。<br/>
    /// 你可以使用空间复杂度为 O(1) 的 原地 算法解决这个问题吗？<br/>
    /// </summary>
    public class Q189_ShiftArrayRight
    {
        public static void Rotate(int[] nums, int k)
        {
            if (nums.Length == 0) return;
            var shiftLen = k % nums.Length;
            if (shiftLen == 0) return;
            Reverse(nums, 0, nums.Length);
            Reverse(nums, 0, shiftLen);
            Reverse(nums, shiftLen, nums.Length - shiftLen);
        }

        private static void Reverse(int[] a, int start, int length)
        {
            if (a.Length == 0) return;
            if (start >= a.Length) return;
            int end = start + length - 1;
            if (end >= a.Length) return;
            while (start < end)
            {
                (a[start], a[end]) = (a[end], a[start]);
                start++;
                end--;
            }
        }
    }
}
