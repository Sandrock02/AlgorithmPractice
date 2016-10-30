using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Commons
{
    public class LinkedNode2Way<T> : IComparable
        where T: IComparable<T>
    {
        public LinkedNode2Way(){}

        public LinkedNode2Way(T value, LinkedNode2Way<T> previous = null, LinkedNode2Way<T> next = null)
        {
            Value = value;
            Previous = previous;
            Next = next;

            if (previous != null)
                previous.Next = this;
            if (next != null)
                next.Previous = this;
        }

        public T Value { get; set; }
        public LinkedNode2Way<T> Previous { get; set; }
        public LinkedNode2Way<T> Next { get; set; }

        public LinkedNode2Way<T> AppendNext(LinkedNode2Way<T> node)
        {
            if (node == null) return this;

            Next = node;
            node.Previous = this;
            return node;
        }

        public int CompareTo(object obj)
        {
            if (this == obj) return 0;

            var other = obj as LinkedNode2Way<T>;
            if (other == null) return 1;

            return Value.CompareTo(other.Value);
        }
    }
}
