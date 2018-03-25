using System;
using System.Linq;
using System.Net.Configuration;
using System.Text.RegularExpressions;
using AlgorithmPractice.Commons;

namespace AlgorithmPractice.Algorithms.BigNumbers
{
    public static class BigNumberHelper
    {
        static readonly Regex Regex = new Regex("^[1-9][0-9]+$");

        public static int[] Plus(int[] v1, int[] v2)
        {
            MakeSameLength(ref v1, ref v2);
            int maxLength = v1.Length;
            var result = new int[maxLength + 1];

            int carry = 0;
            for (int i = 0; i < maxLength; i++)
            {
                (result[i], carry) = PlusNumber(v1[i], v2[i], carry);
            }

            result[maxLength] = carry;

            if (result[maxLength] == 0)
            {
                Array.Resize(ref result, maxLength);
            }
            return result;
        }

        public static int[] Minus(int[] v1, int[] v2)
        {
            MakeSameLength(ref v1, ref v2);
            int maxLength = v1.Length;
            var result = new int[maxLength];

            for (int i = maxLength - 1; i >= 0; i--)
            {
                if (v1[i] < v2[i]) return new int[maxLength];
                if (v1[i] > v2[i]) break;
            }

            int carry = 0;
            for (int i = 0; i < maxLength; i++)
            {
                (result[i], carry) = MinusNumber(v1[i], v2[i], carry);
            }

            return result;
        }

        public static int[] Multiply(int[] v1, int[] v2)
        {
            if (v1 == null || v2 == null || v1.Length == 0 || v2.Length == 0) return new int[0];

            var finalLength = v1.Length + v2.Length;
            var result = new int[finalLength];

            for (int i = 0; i < v2.Length; i++)
            {
                int multiplyCarry = 0;
                int plusCarry = 0;
                for (int j = 0; j < v1.Length; j++)
                {
                    int temp;
                    (temp, multiplyCarry) = MultiplyNumber(v1[j], v2[i], multiplyCarry);
                    (result[j + i], plusCarry) = PlusNumber(result[j + i], temp, plusCarry);
                    plusCarry += multiplyCarry;
                    multiplyCarry = 0;
                }

                result[v1.Length + i] = plusCarry;
            }

            RemoveLeading0s(ref result);

            return result;
        }

        public static int[] MultiplyKaratsuba(int[] v1, int[] v2)
        {
            if (v1 == null || v2 == null || v1.Length == 0 || v2.Length == 0) return new int[0];
            MakeSameLength(ref v1, ref v2);

            if (v1.Length <= 2 && v2.Length <= 2)
            {
                var temp = GetNumberFromArray(v1) * GetNumberFromArray(v2);
                return GetArrayFromNumber(temp);
            }

            // Calculate half
            var halfN = (MathHelper.Max(v1.Length, v2.Length) + 1) / 2;
            var a = v1.Skip(halfN).ToArray();
            var b = v1.Take(halfN).ToArray();
            var c = v2.Skip(halfN).ToArray();
            var d = v2.Take(halfN).ToArray();

            var z2 = MultiplyKaratsuba(a, c);
            var z0 = MultiplyKaratsuba(b, d);
            var aPb = Plus(a, b);
            var cPd = Plus(c, d);
            var z0Pz2 = Plus(z0, z2);
            var aPbMcPd = MultiplyKaratsuba(aPb, cPd);
            var z1 = Minus(aPbMcPd, z0Pz2);

            var z2Power10 = GetArrayMultiply10PowerN(z2, 2 * halfN);
            var z1Power10 = GetArrayMultiply10PowerN(z1, halfN);
            var z1Power10Pz0 = Plus(z1Power10, z0);
            var result = Plus(z2Power10, z1Power10Pz0);

            RemoveLeading0s(ref result);
            return result;
        }

        public static long GetNumberFromArray(int[] arr)
        {
            if (arr.Length >= 3)
            {
                throw new ArgumentOutOfRangeException();
            }

            long result = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                result = result * 10 + arr[i];
            }

            return result;
        }

        public static int[] GetArrayFromNumber(long number)
        {
            return number.ToString().Reverse().Select(t => t - '0').ToArray();
        }
        
        public static int[] GetArrayFromString(string str)
        {
            if(string.IsNullOrWhiteSpace(str)) return new int[0];
            if (Regex.IsMatch(str))
            {
                return str.ToCharArray().Select(t => t - '0').Reverse().ToArray();
            }

            throw new ArgumentException("Invlid input: " + str);
        }

        public static int[] GetArrayMultiply10PowerN(int[] arr, int n)
        {
            var result = new int[arr.Length + n];
            Array.Copy(arr, 0, result, n, arr.Length);
            return result;
        }

        private static void MakeSameLength(ref int[] v1, ref int[] v2)
        {
            if (v1 == null) v1 = new int[0];
            if (v2 == null) v2 = new int[0];
            if (v1.Length == 0 && v2.Length == 0) return;

            if (v1.Length > v2.Length)
            {
                Array.Resize(ref v2, v1.Length);
            }
            else if (v1.Length < v2.Length)
            {
                Array.Resize(ref v1, v2.Length);
            }
        }

        private static void RemoveLeading0s(ref int[] arr)
        {
            var length = arr.Length - 1;
            while (length >= 0)
            {
                if (arr[length] == 0) length--;
                else break;
            }

            Array.Resize(ref arr, length + 1);
        }

        public static (int n, int carry) PlusNumber(int v1, int v2, int carry)
        {
            var temp = v1 + v2 + carry;
            return (temp % 10, temp / 10);
        }

        public static (int n, int carry) MinusNumber(int v1, int v2, int carry)
        {
            var temp = v1 + carry - v2;
            return ((temp + 10) % 10, temp < 0 ? -1 : 0);

        }

        public static (int n, int carry) MultiplyNumber(int v1, int v2, int carry)
        {
            var temp = v1 * v2 + carry;
            return (temp % 10, temp / 10);
        }
    }
}
