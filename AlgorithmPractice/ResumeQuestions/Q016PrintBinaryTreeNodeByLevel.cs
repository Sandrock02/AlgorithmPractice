using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmPractice.Commons;

namespace AlgorithmPractice.MicrosoftResumeQuestions
{
    public static class Q016PrintBinaryTreeNodeByLevel
    {
        /// <summary>
        /// Q016 Print Binary Tree Node By Level
        /// </summary>
        /// <remarks>
        /// Q016
        /// 题目（微软）：
        /// 输入一颗二元树，从上往下按层打印树的每个结点，同一层中按照从左往右的顺序打印。
        /// 例如输入
        ///     8
        ///   /   \
        ///  6    10
        /// / \  /  \
        /// 5 7 9   11
        /// 输出8 6 10 5 7 9 11。
        /// </remarks>
        public static string Print<T>(BinaryTreeNode<T> root)
            where T : IComparable<T>
        {
            if (root == null) return string.Empty;

            var buff = new Queue<BinaryTreeNode<T>>();
            buff.Enqueue(root);

            var sb = new StringBuilder();

            while (buff.Count > 0)
            {
                var node = buff.Dequeue();
                if(node == null) continue;

                sb.AppendFormat("{0} ", node.Value);

                buff.Enqueue(node.LeftChild);
                buff.Enqueue(node.RightChild);
            }

            return sb.ToString();
        }
    }
}
