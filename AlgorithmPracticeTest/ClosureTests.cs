using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPracticeTest
{
    [TestClass]
    public class ClosureTests
    {
        [TestMethod]
        public void TestClosure01()
        {
            for(int i=0;i<10;i++)
            {
                DoActon(()=> Console.WriteLine(i));
            }


        }

        private void DoActon(Action func)
        {
            func();
        }

        [TestMethod]
        public void TestClosure02()
        {
            var a = new TCloser();
            var b = a.T1();
            var c = a.T2();
            Console.WriteLine(b());
            Console.WriteLine(c.A);

            Func<int, int> t = v => v;
            for (int i = 0; i < 4; i++)
                Console.WriteLine(t(i));

            int j = 0;
            Func<int> m= () => j;
            for (j = 0; j < 4; j++)
            {
                Console.WriteLine(m());
            }
        }

        [TestMethod]
        public void TestTryCatch()
        {
            
        }

        private int GetValue()
        {
            try
            {
                return 10;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                //return 100;
            }
        }
    }


    public class TCloser
    {
        public Func<int> T1()
        {
            var n = 999;
            Func<int> result = () =>
            {
                return n;
            };
            n = 10;
            return result;
        }
        public dynamic T2()
        {
            var n = 999;
            dynamic result = new { A = n };
            n = 10;
            return result;
        }
    }

    

    static class ListUtil
    {
        public static IList<T> Filter<T>(IList<T> source, Predicate<T> predicate)
        {
            List<T> ret = new List<T>();
            foreach (T item in source)
            {
                if (predicate(item))
                {
                    ret.Add(item);
                }
            }
            return ret;
        }
    }
}
