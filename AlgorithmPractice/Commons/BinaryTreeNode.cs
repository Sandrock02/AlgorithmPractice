namespace AlgorithmPractice.Commons
{
    using System;

    public class BinaryTreeNode<T> : IComparable
        where T: IComparable<T>
    {
        public BinaryTreeNode()
        {
        }

        public BinaryTreeNode(T value, BinaryTreeNode<T> leftChild = null, BinaryTreeNode<T> rightChild = null  )
        {
            this.Value = value;
            this.LeftChild = leftChild;
            this.RightChild = rightChild;
        }

        public T Value { get; set; }

        public BinaryTreeNode<T> LeftChild { get; set; }

        public BinaryTreeNode<T> RightChild { get; set; }

        public object Tag { get; set; }

        public int CompareTo(object obj)
        {
            if (this == obj)
            {
                return 0;
            }

            var other = obj as BinaryTreeNode<T>;
            if (other == null)
            {
                return 1;
            }

            return this.Value.CompareTo(other.Value);
        }

        public override string ToString()
        {
            return string.Format("Value: {0}", this.Value);
        }
    }
}
