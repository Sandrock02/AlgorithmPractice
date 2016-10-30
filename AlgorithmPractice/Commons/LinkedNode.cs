using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Commons
{
    public class LinkedNode<T> : IComparable
        where T: IComparable<T>
    {
        public LinkedNode(){}

        public LinkedNode(T value, LinkedNode<T> next = null, LinkedNode<T> previous = null)
        {
            Value = value;
            Next = next;
            if (previous != null)
                previous.Next = this;
        }

        public T Value { get; set; }
        public LinkedNode<T> Next { get; set; }

        public LinkedNode<T> Append(LinkedNode<T> next)
        {
            if (next == null) return this;

            Next = next;
            return next;
        }

        public override string ToString()
        {
            return string.Format("Value: {0}  Next:{1}", Value, Next.Value);
        }

        public int CompareTo(object obj)
        {
            if (this == obj) return 0;

            var other = obj as LinkedNode<T>;
            if (other == null) return 1;

            return Value.CompareTo(other.Value);
        }
    }
}
