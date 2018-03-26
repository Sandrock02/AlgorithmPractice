using System;
using AlgorithmPractice.Commons;

namespace AlgorithmPractice.ResumeQuestions
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Q007
    /// 微软亚院之编程判断俩个链表是否相交
    /// 给出俩个单向链表的头指针，比如 h1，h2，判断这俩个链表是否相交。
    /// 为了简化问题，我们假设俩个链表均不带环。
    /// 问题扩展：
    /// 1.如果链表可能有环列?
    /// 2.如果需要求出俩个链表相交的第一个节点列?
    /// </remarks>
    public static class Q007CheckLinkedListsAreJoin
    {
        // 相交的链表的意思是从两个链表的某一个节点开始，后面的节点都是一样的

        public static bool AreJoin<T>(LinkedNode<T> h1, LinkedNode<T> h2)
            where T : IComparable<T>
        {
            if (h1 == null || h2 == null) return false;

            var th1 = h1;
            var th2 = h2;
            while (th1.Next != null)
                th1 = th1.Next;
            while (th2.Next != null)
                th2 = th2.Next;

            return th1 == th2;
        }

        public static bool AreJoinWithCylic<T>(LinkedNode<T> h1, LinkedNode<T> h2)
            where T : IComparable<T>
        {
            var r1 = h1.TestHasCylic();
            var r2 = h2.TestHasCylic();

            if (r1 == null && r2 == null) return AreJoin(h1, h2);
            if (r1 == null || r2 == null) return false;

            // 为了检查当一个链表的循环头在另一个链表的环内
            LinkedNode<T> p = r1;
            while (true)
            {
                if (p == r2 || p.Next == r2) return true;
                p = p.Next.Next;
                r1 = r1.Next;

                if (p == r1) return false;
            }
        }
    }
}
