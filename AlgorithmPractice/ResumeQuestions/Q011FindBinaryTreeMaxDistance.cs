using System;
using AlgorithmPractice.Commons;

namespace AlgorithmPractice.ResumeQuestions
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Q011
    /// 求二叉树中节点的最大距离...
    /// 如果我们把二叉树看成一个图，父子节点之间的连线看成是双向的，
    /// 我们姑且定义"距离"为两节点之间边的个数。
    /// 写一个程序，
    /// 求一棵二叉树中相距最远的两个节点之间的距离。
    /// </remarks>
    public class Q011FindBinaryTreeMaxDistance
    {
        public int FindBinaryTreeMaxDistance<T>(BinaryTreeNode<T> root)
            where T : IComparable<T>
        {
            int depth;
            return FindNodeMaxDistance(root, out depth);
        }
        public int FindNodeMaxDistance<T>(BinaryTreeNode<T> root, out int depth)
            where T : IComparable<T>
        {
            if (root == null)
            {
                depth = 0;
                return 0;
            }

            int ld, rd;
            var maxleft = FindNodeMaxDistance(root.LeftChild, out ld);
            var maxright = FindNodeMaxDistance(root.RightChild, out rd);
            depth = Math.Max(ld, rd) + 1;
            return Math.Max(maxleft, Math.Max(maxright, ld + rd));
        }
    }
}
