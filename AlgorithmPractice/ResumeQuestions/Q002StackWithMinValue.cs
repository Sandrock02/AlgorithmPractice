using System;
using System.Collections.Generic;

namespace AlgorithmPractice.MicrosoftResumeQuestions
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 设计包含 min 函数的栈。
    /// 定义栈的数据结构，要求添加一个 min 函数，能够得到栈的最小元素。
    /// 要求函数 min、push 以及 pop 的时间复杂度都是 O(1)。
    /// </remarks>
    public class Q002StackWithMinValue<T> where T : IComparable<T>
    {
        private class StackItem
        {
            public StackItem(T value)
            {
                Value = value;
            }

            public T Value { get; private set; }
            public StackItem MinItem { get; set; }
        }

        private readonly Stack<StackItem> _InternalStack;

        public Q002StackWithMinValue()
        {
            _InternalStack = new Stack<StackItem>();
        }

        public Q002StackWithMinValue(int capacity)
        {
            _InternalStack = new Stack<StackItem>(capacity);
        }

        public void Push(T value)
        {
            var item = new StackItem(value);
            if (_InternalStack.Count == 0)
            {
                item.MinItem = item;
            }
            else
            {
                var topItem = _InternalStack.Peek();
                item.MinItem = item.Value.CompareTo(topItem.MinItem.Value) < 0 ? item : topItem.MinItem;
            }

            _InternalStack.Push(item);
        }

        public T Pop()
        {
            return _InternalStack.Pop().Value;
        }

        public T GetMinValue()
        {
            return _InternalStack.Peek().MinItem.Value;
        }
    }
}
