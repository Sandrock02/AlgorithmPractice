namespace AlgorithmPractice.Commons
{
    using System;
    using System.Collections.Generic;

    public class MultipleTreeNode<T> : IComparable
        where T : IComparable<T>
    {
        public MultipleTreeNode()
        {
            Children = new List<MultipleTreeNode<T>>();
        }

        public MultipleTreeNode(T value, params MultipleTreeNode<T>[] children)
        {
            Value = value;
            Children = new List<MultipleTreeNode<T>>();

            if (children != null)
            {
                Children.AddRange(children);
            }
        }

        public T Value { get; set; }

        public List<MultipleTreeNode<T>> Children { get; }

        public object Tag { get; set; }

        public int CompareTo(object obj)
        {
            if (this == obj)
            {
                return 0;
            }

            var other = obj as MultipleTreeNode<T>;
            if (other == null)
            {
                return 1;
            }

            return Value.CompareTo(other.Value);
        }
    }
}
