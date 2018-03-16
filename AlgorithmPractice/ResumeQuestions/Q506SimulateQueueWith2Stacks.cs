using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.ResumeQuestions
{
    public class SimulatedQueue<T>
    {
        private Stack<T> _S1;
        private Stack<T> _S2;

        public SimulatedQueue()
        {
            _S1 = new Stack<T>();
            _S2 = new Stack<T>();
        }

        public int Count => _S1.Count + _S2.Count;

        public void Enqueue(T value)
        {
            _S1.Push(value);
        }

        public T Dequeue()
        {
            if (_S2.Count == 0)
            {
                while (_S1.Count > 0)
                {
                    _S2.Push(_S1.Pop());
                }
            }

            return _S2.Pop();
        }
    }
}
