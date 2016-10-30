using System;

namespace AlgorithmPractice.Commons
{
    public class Node<T> where T: IComparable<T>
    {
        public Node(T value, Node<T> linkp = null, Node<T> linkn = null)
        {
            Value = value;
            LinkP = linkp;
            LinkN = linkn;
        }
        public T Value { get; set; }
        public Node<T> LinkP { get; set; }
        public Node<T> LinkN { get; set; }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
