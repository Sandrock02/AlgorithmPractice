using System;
using AlgorithmPractice.Commons;

namespace AlgorithmPractice.MicrosoftResumeQuestions
{
    public static class Q101ReverseEvery2NodesInLinkedList
    {
        public static LinkedNode<T> Reverse<T>(LinkedNode<T> node)
            where T: IComparable<T>
        {
            if (node == null) return null;
            if (node.Next == null) return node;

            var head = node.Next;
            var pre = new LinkedNode<T>(default(T), node);
            var cur = pre.Next;

            while (cur != null && cur.Next != null)
            {
                var t = cur.Next.Next;
                pre.Next = cur.Next;
                pre.Next.Next = cur;
                cur.Next = t;

                pre = cur;
                cur = t;
            }

            return head;
        }

        public static LinkedNode<T> ReverseRecursivly<T>(LinkedNode<T> node)
            where T : IComparable<T>
        {
            return DoRecursivly(new LinkedNode<T>(default(T), node), node);
        }

        private static LinkedNode<T> DoRecursivly<T>(LinkedNode<T> pre, LinkedNode<T> cur)
            where T : IComparable<T>
        {
            if (cur == null) return null;
            if (cur.Next == null) return cur;

            var newHead = DoRecursivly(cur.Next, cur.Next.Next);
            pre.Next = cur.Next;
            pre.Next.Next = cur;
            cur.Next = newHead;

            return pre.Next;
        }


    }
}
