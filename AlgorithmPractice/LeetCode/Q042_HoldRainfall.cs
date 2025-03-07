using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.LeetCode
{
    /// <summary>
    /// 
    /// </summary>
    public class Q042_HoldRainfall
    {
        public static int Trap(int[] height)
        {
            if (height.Length == 0) return 0;

            var lMax = height[0];
            var rMax = height[^1];

            var l = 0;
            var r = height.Length - 1;
            var total = 0;

            while (l < r)
            {
                lMax = Math.Max(lMax, height[l]);
                rMax = Math.Max(rMax, height[r]);

                if (lMax < rMax)
                {
                    total += lMax - height[l];
                    l++;
                }
                else
                {
                    total += rMax - height[r];
                    r--;
                }
            }

            return total;
        }
    }
}
