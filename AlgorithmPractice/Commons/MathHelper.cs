using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Commons
{
    public static class MathHelper
    {
        public static T Max<T>(params T[] objects)
        {
            return objects.Max();
        }

        public static T Min<T>(params T[] objects)
        {
            return objects.Min();
        }
    }
}
