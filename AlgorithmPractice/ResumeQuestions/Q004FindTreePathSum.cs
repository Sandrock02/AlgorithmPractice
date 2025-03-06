using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmPractice.Commons;

namespace AlgorithmPractice.ResumeQuestions
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 4.在二元树中找出和为某一值的所有路径
    /// 题目：输入一个整数和一棵二元树。
    /// 从树的根结点开始往下访问一直到叶结点所经过的所有结点形成一条路径。
    /// 打印出和与输入整数相等的所有路径。
    /// 例如输入整数22 和如下二元树
    ///    10
    ///   / \
    ///  5   12
    /// / \
    /// 4 7
    /// 则打印出两条路径：10, 12 和10, 5, 7。
    /// </remarks>
    public class Q004FindTreePathSum
    {
        public List<string> FindTreePathSumInt32(BinaryTreeNode<int> root, long sum)
        {
            if (root == null) throw new ArgumentNullException();

            var pathStack = new Stack<BinaryTreeNode<int>>();

            return GetChildSum(root, pathStack, sum);
        }

        private List<string> GetChildSum(BinaryTreeNode<int> node, Stack<BinaryTreeNode<int>> pathStack, long sum)
        {
            var resultPaths = new List<string>();
            if (node == null) return resultPaths;

            pathStack.Push(node);
            sum -= node.Value;
            if (sum == 0)
            {
                var result = pathStack.Select(t => t.Value).ToList();
                result.Reverse();
                resultPaths.Add(string.Join("->", result));

                pathStack.Pop();
                return resultPaths;
            };

            if (sum > 0)
            {
                var rLeft = GetChildSum(node.LeftChild, pathStack, sum);
                var rRight = GetChildSum(node.RightChild, pathStack, sum);
                resultPaths.AddRange(rLeft);
                resultPaths.AddRange(rRight);
            }

            pathStack.Pop();
            return resultPaths;
        }
    }
}
