using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.ResumeQuestions
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Q028
    /// 整数的二进制表示中1 的个数
    /// 题目：输入一个整数，求该整数的二进制表达中有多少个1。
    /// 例如输入10，由于其二进制表示为1010，有两个1，因此输出2。
    /// </remarks>
    public static class Q028Find1CountInNumber
    {
        public static int Find1CountInNumber(int num)
        {
            int count = 0;
            while (num != 0)
            {
                num = num & (num - 1);
                count++;
            }

            return count;
        }
    }
}
