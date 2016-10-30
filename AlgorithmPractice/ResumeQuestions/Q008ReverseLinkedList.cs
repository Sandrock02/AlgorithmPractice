using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmPractice.Commons;

namespace AlgorithmPractice.MicrosoftResumeQuestions
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Q008_1: 用一种算法来颠倒一个链接表的顺序。现在在不用递归式的情况下做一遍。
    /// </remarks>
    public static class Q008ReverseLinkedList
    {
        public static LinkedNode<T> Reverse<T>(LinkedNode<T> head)
            where T : IComparable<T>
        {
            var cur = head;
            LinkedNode<T> pre = null;

            while (cur != null)
            {
                LinkedNode<T> next = cur.Next;
                cur.Next = pre;
                pre = cur;
                cur = next;
            }

            return pre;
        }

        public static LinkedNode<T> ReverseRecursive<T>(LinkedNode<T> head)
            where T : IComparable<T>
        {
            if (head == null || head.Next == null) return head;

            LinkedNode<T> node = ReverseRecursive(head.Next);
            head.Next.Next = head;
            head.Next = null;
            return node;
        }
    }
}
