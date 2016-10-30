namespace AlgorithmPractice.Algorithms
{
    using System;
    using System.Text;

    using AlgorithmPractice.Commons;

    public static class Fibonacci
    {
        private static readonly double Sqrt5 = Math.Sqrt(5d);

        public static long GetNByRecursive(int n)
        {
            if (n > 20)
            {
                var sb = new StringBuilder();
                sb.AppendLine("The n for this method is too large to execute. The performance might be very low.");
                sb.AppendLine("Please consider use other methods in this class");
                throw new ArgumentException(sb.ToString());
            }

            if (n == 1 || n == 2) return 1;

            return GetNByRecursive(n - 2) + GetNByRecursive(n - 1);
        }

        public static long GetNByIteration(int n)
        {
            long x = 1;
            long y = 1;
            for (int j = 1; j < n; j++)
            {
                y = x + y;
                x = y - x;
            }

            return y;
        }

        public static long GetNByCommonFormular(int n)
        {
            double x = (1 + Sqrt5) / 2;
            double y = (1 - Sqrt5) / 2;
            return (long)((Math.Pow(x, n) - Math.Pow(y, n)) / Sqrt5 + 0.5);
        }

        public static long GetNByMatrix(int n)
        {
            var m = new Matrix(2, 2);
            m.ele[0, 0] = 1;
            m.ele[0, 1] = 1;
            m.ele[1, 0] = 1;
            m.ele[1, 1] = 0;

            var result = Power(m, n - 1);
            return (long)result.ele[0, 0];
        }

        private static Matrix Power(Matrix m, int n)
        {
            if (n == 1) return m;

            if (n % 2 == 0)
            {
                return Power(m * m, n / 2);
            }

            return Power(m * m, n / 2) * m;
        }
    }
}
