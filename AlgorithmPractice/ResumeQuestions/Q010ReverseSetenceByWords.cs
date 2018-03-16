using System.Linq;

namespace AlgorithmPractice.ResumeQuestions
{
    public static class Q010ReverseSetenceByWords
    {
        public static string ReverseSetenceByWords(string sentence)
        {
            var charArray = sentence.Reverse().ToArray();
            int startIndex = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == ' ')
                {
                    ReverseCharArray(charArray, startIndex, i - 1);
                    startIndex = i + 1;
                }
            }

            return new string(charArray);
        }

        public static string ReverseSetenceByWordsLinq(string sentence)
        {
            var rev = new string(sentence.Reverse().ToArray());
            var words = rev.Split(new[] { ' ' });
            string[] reversed = words.Select(t => new string(t.Reverse().ToArray())).ToArray();
            return string.Join(" ", reversed);
        }

        private static void ReverseCharArray(char[] charArray, int startIndex, int endIndex)
        {
            while (startIndex < endIndex)
            {
                char temp = charArray[startIndex];
                charArray[startIndex] = charArray[endIndex];
                charArray[endIndex] = temp;
                startIndex++;
                endIndex--;
            }
        }

        public static void ReverseCharArrayAdvance(char[] charArray, int startIndex, int endIndex)
        {
            for (; startIndex < endIndex; startIndex++, endIndex--)
            {
                charArray[startIndex] ^= charArray[endIndex];
                charArray[endIndex] ^= charArray[startIndex];
                charArray[startIndex] ^= charArray[endIndex];
            }
        }
    }
}
