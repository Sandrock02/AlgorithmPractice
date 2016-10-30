using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.MicrosoftResumeQuestions
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 找出数组中两个只出现一次的数字
    /// 题目：一个整型数组里除了两个数字之外，其他的数字都出现了两次。
    /// 请写程序找出这两个只出现一次的数字。要求时间复杂度是 O(n)，空间复杂度是 O(1)。
    /// 分析：这是一道很新颖的关于位运算的面试题。
    /// ANSWER:
    /// XOR.
    /// </remarks>
    public static class Q061FindNumberOnlyOccurOnce
    {
        public static Tuple<int, int> FindNumberOnlyOccurOnce(int[] a)
        {
            int all = 0;
            for (int i = 0; i < a.Length; i++)
            {
                all = all ^ a[i];
            }

            Console.WriteLine(Convert.ToString(all, 2));


            int flag = 1;
            while ((all & flag) != 1)
                flag <<= 1;

            int r1 = 0;
            int r2 = 0;
            foreach (int t in a)
            {
                if ((flag & t) == 1)
                    r1 ^= t;
                else
                    r2 ^= t;
            }

            return new Tuple<int, int>(r1, r2);
            ;
        }
    }
}
