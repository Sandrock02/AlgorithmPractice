using System.Collections.Generic;

namespace AlgorithmPractice.MicrosoftResumeQuestions
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 字符串的排列。
    /// 题目：输入一个字符串，打印出该字符串中字符的所有排列。
    /// 例如输入字符串 abc，则输出由字符 a、b、c 所能排列出来的所有字符串
    /// abc、acb、bac、bca、cab 和 cba。
    /// </remarks>
    public class Q053PrintAllPermutation
    {
        private List<string> ResultString { get; set; }
 
        public Q053PrintAllPermutation()
        {
            ResultString = new List<string>();
        }

        public string[] PrintAllPermutation(char[] chars)
        {
            ResultString.Clear();
            TryGeneratePermutation(chars, 0);

            return ResultString.ToArray();
        }

        private void TryGeneratePermutation(char[] chars, int start)
        {
            if (start == chars.Length - 1)
                ResultString.Add(new string(chars));

            for (int i = start; i < chars.Length; i++)
            {
                Swap(chars, start, i);
                TryGeneratePermutation(chars, start + 1);
                Swap(chars, start, i);
            }
        }

        private char temp;
        private void Swap(char[] chars, int i, int j)
        {
            if (i == j) return;
            temp = chars[i];
            chars[i] = chars[j];
            chars[j] = temp;
        }
    }
}
