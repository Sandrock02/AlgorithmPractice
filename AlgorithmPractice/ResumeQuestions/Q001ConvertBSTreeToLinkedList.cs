using System;
using AlgorithmPractice.Commons;

namespace AlgorithmPractice.MicrosoftResumeQuestions
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 1.把二元查找树转变成排序的双向链表
    /// 题目：
    /// 输入一棵二元查找树，将该二元查找树转换成一个排序的双向链表。
    /// 要求不能创建任何新的结点，只调整指针的指向。
    ///     10
    ///   /    \
    ///  6     14
    /// / \   /  \
    /// 4  8 12  16
    /// 转换成双向链表
    /// 4=6=8=10=12=14=16
    /// </remarks>
    public static class Q001ConvertBSTreeToLinkedList
    {
        public static void Convert<T>(Node<T> tree, out Node<T> head, out Node<T> tail) where T : IComparable<T>
        {
            if (tree == null)
            {
                head = null;
                tail = null;
                return;
            }

            Node<T> h, t;
            Convert(tree.LinkP, out h, out t);
            tree.LinkP = t;
            if (t != null) t.LinkN = tree;
            head = h ?? tree;

            Convert(tree.LinkN, out h, out t);
            tree.LinkN = h;
            if (h != null) h.LinkP = tree;
            tail = t ?? tree;
        }
    }
}
