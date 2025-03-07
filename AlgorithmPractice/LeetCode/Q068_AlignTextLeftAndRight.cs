using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.LeetCode
{
    /// <summary>
    /// 68. 文本左右对齐
    /// <br/>困难
    /// <br/>    相关标签
    /// <br/>相关企业
    /// <br/>    给定一个单词数组 words 和一个长度 maxWidth ，重新排版单词，使其成为每行恰好有 maxWidth 个字符，且左右两端对齐的文本。
    /// <br/>
    /// <br/>你应该使用 “贪心算法” 来放置给定的单词；也就是说，尽可能多地往每行中放置单词。必要时可用空格 ' ' 填充，使得每行恰好有 maxWidth 个字符。
    /// <br/>
    /// <br/>要求尽可能均匀分配单词间的空格数量。如果某一行单词间的空格不能均匀分配，则左侧放置的空格数要多于右侧的空格数。
    /// <br/>
    /// <br/>文本的最后一行应为左对齐，且单词之间不插入额外的空格。
    /// <br/>
    /// <br/>注意:
    /// <br/>
    /// <br/>单词是指由非空格字符组成的字符序列。
    /// <br/>每个单词的长度大于 0，小于等于 maxWidth。
    /// <br/>输入单词数组 words 至少包含一个单词。
    /// <br/>
    /// <br/>
    /// <br/>示例 1:
    /// <br/>
    /// <br/>输入: words = ["This", "is", "an", "example", "of", "text", "justification."], maxWidth = 16
    /// <br/>输出:
    /// <br/>[
    /// <br/>"This    is    an",
    /// <br/>"example  of text",
    /// <br/>"justification.  "
    /// <br/>    ]
    /// <br/>示例 2:
    /// <br/>
    /// <br/>输入:words = ["What", "must", "be", "acknowledgment", "shall", "be"], maxWidth = 16
    /// <br/>输出:
    /// <br/>[
    /// <br/>"What   must   be",
    /// <br/>"acknowledgment  ",
    /// <br/>"shall be        "
    /// <br/>    ]
    /// <br/>解释: 注意最后一行的格式应为 "shall be    " 而不是 "shall     be",
    /// <br/>因为最后一行应为左对齐，而不是左右两端对齐。       
    /// <br/>第二行同样为左对齐，这是因为这行只包含一个单词。
    /// <br/>示例 3:
    /// <br/>
    /// <br/>输入:words = ["Science", "is", "what", "we", "understand", "well", "enough", "to", "explain", "to", "a", "computer.", "Art", "is", "everything", "else", "we", "do"]，maxWidth = 20
    /// <br/>输出:
    /// <br/>[
    /// <br/>"Science  is  what we",
    /// <br/>"understand      well",
    /// <br/>"enough to explain to",
    /// <br/>"a  computer.  Art is",
    /// <br/>"everything  else  we",
    /// <br/>"do                  "
    /// <br/>    ]
    /// <br/>
    /// <br/>
    /// <br/>提示:
    /// <br/>
    /// <br/>1 &lt;= words.length &lt;= 300
    /// <br/>1 &lt;= words[i].length &lt;= 20
    /// <br/>words[i] 由小写英文字母和符号组成
    /// <br/>1 &lt;= maxWidth &lt;= 100
    /// <br/>words[i].length &lt;= maxWidth
    /// </summary>
    public class Q068_AlignTextLeftAndRight
    {
        public static IList<string> FullJustify(string[] words, int maxWidth)
        {
            // Find as more as words
            var start = 0;
            var total = 0;
            var cur = 0;
            var result = new List<string>();
            while (cur < words.Length)
            {
                var currentCount = words[cur].Length;
                var len = cur - start;
                if (total + currentCount + len > maxWidth)
                {
                    result.Add(FillSpaces(words.AsSpan(start, cur - start), maxWidth, total));
                    start = cur;
                    total = currentCount;
                }
                else
                {
                    total += currentCount;
                }

                cur++;
            }

            result.Add(FillLastLine(words.AsSpan(start, cur - start), maxWidth));

            return result;
        }

        private static string FillSpaces(ReadOnlySpan<string> words, int maxWidth, int totalWordsLen)
        {
            var diff = maxWidth - totalWordsLen;
            var spaceCount = words.Length - 1;

            int min;
            int remain;
            if (spaceCount == 0)
            {
                min = diff;
                remain = 0;
                spaceCount = 1;
            }
            else
            {
                min = diff / spaceCount;
                remain = diff % spaceCount;
            }

            var sb = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                sb.Append(words[i]);
                if (i < spaceCount)
                {
                    var t = min + (i < remain ? 1 : 0);
                    while (t > 0)
                    {
                        sb.Append(' ');
                        t--;
                    }
                }
            }

            var result = sb.ToString();
            return result;
        }

        private static string FillLastLine(ReadOnlySpan<string> words, int maxWidth)
        {
            var left = String.Join(' ', words.ToArray());
            var remain = maxWidth - left.Length;
            var sb = new StringBuilder();
            sb.Append(left);
            while (remain > 0)
            {
                sb.Append(' ');
                remain--;
            }

            return sb.ToString();
        }
    }
}
