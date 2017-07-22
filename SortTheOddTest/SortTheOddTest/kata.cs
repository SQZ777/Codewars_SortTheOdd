using System;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortTheOddTest
{
    [TestClass]
    public class kata
    {
        [TestMethod]
        public void Input_0_Should_Be_0()
        {
            sortResult(new[] { 0 }, new[] { 0 });
        }

        [TestMethod]
        public void Input_1_2_Should_Be_1_2()
        {
            sortResult(new[] { 1, 2 }, new[] { 1, 2 });
        }

        [TestMethod]
        public void Input_1_3_Should_Be_3_1()
        {
            sortResult(new[] { 1, 3 }, new[] { 3, 1 });
        }

        [TestMethod]
        public void Input_3_1_Should_Be_1_3()
        {
            sortResult(new[] { 1, 3 }, new[] { 3, 1 });
        }

        [TestMethod]
        public void Input_1_3_5_Should_Be_5_3_1()
        {
            sortResult(new[] { 1, 3, 5 }, new[] { 5, 3, 1 });
        }

        [TestMethod]
        public void Input_5_3_2_8_1_4_Should_Be_1_3_2_8_5_4()
        {
            sortResult(new[] { 1, 3, 2, 8, 5, 4 }, new[] { 5, 3, 2, 8, 1, 4 });
        }

        [TestMethod]
        public void Input_5_3_1_8_0_Should_Be_1_3_5_8_0()
        {
            sortResult(new[] { 1, 3, 5, 8, 0 }, new[] { 5, 3, 1, 8, 0 });
        }

        [TestMethod]
        public void Input_83_13_Should_Be_13_83()
        {
            sortResult(new[] { 13, 83 }, new[] { 83, 13 });
        }

        private static void sortResult(int[] expected, int[] input)
        {
            var kata = new Kata();
            var actual = kata.sortTheOdd(input);
            CollectionAssert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public int[] sortTheOdd(int[] array)
        {
            int oddCount = 0;
            var test = array.Where(x => x % 2 == 1).OrderBy(x => x).ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    array[i] = test[oddCount];
                    oddCount++;
                }
            }
            return array;
        }
        
    }
}
