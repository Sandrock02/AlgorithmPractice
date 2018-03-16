using System;

namespace AlgorithmPractice.ResumeQuestions
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Q009:
    /// 判断整数序列是不是二元查找树的后序遍历结果
    /// 题目：输入一个整数数组，判断该数组是不是某二元查找树的后序遍历的结果。
    /// 如果是返回 true，否则返回 false。
    /// 例如输入5、7、6、9、11、10、8，由于这一整数序列是如下树的后序遍历结果：
    ///    8
    ///   / \
    ///  6   10
    /// / \ /  \
    /// 5 7 9  11
    /// 因此返回 true。
    /// 如果输入7、4、6、5，没有哪棵树的后序遍历的结果是这个序列，因此返回 false。
    /// </remarks>
    public static class Q009CheckPostOrderResult
    {
        public static bool VerifySquenceOfBst(int[] squence, int length)
        {
            if (squence == null || length <= 0)
                return false;

            // root of a BST is at the end of post order traversal squence
            int root = squence[length - 1];

            // the nodes in left sub-tree are less than the root
            int i = 0;
            for (; i < length - 1; ++i)
            {
                if (squence[i] > root)
                    break;
            }

            // the nodes in the right sub-tree are greater than the root
            int j = i;
            for (; j < length - 1; ++j)
            {
                if (squence[j] < root)
                    return false;
            }

            // verify whether the left sub-tree is a BST
            bool left = true;
            if (i > 0)
            {
                var newSequence = new int[i];
                Array.Copy(squence, 0, newSequence, 0, i);

                left = VerifySquenceOfBst(newSequence, i);
            }

            // verify whether the right sub-tree is a BST
            bool right = true;
            if (i < length - 1)
            {
                var newSequence = new int[length - i - 1];
                Array.Copy(squence, i + 1, newSequence, 0, length - i - 1);
                right = VerifySquenceOfBst(newSequence, length - i - 1);
            }

            return (left && right);
        }
    }
}
