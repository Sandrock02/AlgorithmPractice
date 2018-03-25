using System;

namespace AlgorithmPractice.Commons
{
    public class Node<T> : IComparable<Node<T>>, IComparable
        where T: IComparable<T>
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

        public int CompareTo(T other)
        {
            return Value.CompareTo(other);
        }

        public int CompareTo(Node<T> other)
        {
            return Value.CompareTo(other.Value);
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            if (obj is Node<T> n)
            {
                return Value.CompareTo(n.Value);
            }

            throw new ArgumentException("Unsupported argument");
        }
    }
}
