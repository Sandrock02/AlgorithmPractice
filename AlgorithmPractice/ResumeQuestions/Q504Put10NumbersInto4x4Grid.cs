namespace AlgorithmPractice.ResumeQuestions
{
    using System.Collections.Generic;

    public static class Q504Put10NumbersInto4X4Grid
    {
        private const int TotalLength = 131071;

        public static List<bool[]> Put10NumbersInto4X4Grid()
        {
            var result = new List<bool[]>();
            var stack = new Stack<bool>();
            for (var i = 65536; i > 0; i--)
            {
                stack.Clear();
                var index = TotalLength - i;
                var count = 0;
                while (index > 0)
                {
                    var value = index % 2;
                    count += value;
                    stack.Push(value == 1);

                    index = (index - 1) >> 1;
                }

                if (count == 10)
                {
                    var array = stack.ToArray();
                    if (Validate(array))
                    {
                        result.Add(array);
                    }
                }
            }

            return result;
        }

        private static bool Validate(bool[] data)
        {
            for (int i = 0; i < 4; i++)
            {
                var a = data[i * 4 + 0] ? 1 : 0;
                var b = data[i * 4 + 1] ? 1 : 0;
                var c = data[i * 4 + 2] ? 1 : 0;
                var d = data[i * 4 + 3] ? 1 : 0;

                if ((a + b + c + d) % 2 == 1) return false;
            }

            for (int i = 0; i < 4; i++)
            {
                var a = data[0 + i] ? 1 : 0;
                var b = data[4 + i] ? 1 : 0;
                var c = data[8 + i] ? 1 : 0;
                var d = data[12 + i] ? 1 : 0;

                if((a+b+c+d) % 2 == 1) return false;
            }

            return true;
        }
    }
}
