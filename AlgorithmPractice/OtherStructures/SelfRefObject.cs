using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.OtherStructures
{
    public class SelfRefObject<T>
    {
        public SelfRefObject(T obj)
        {
            this.Value = obj;
        }

        public SelfRefObject<T> Parent { get; set; }

        public T Value { get; set; }
    }
}
