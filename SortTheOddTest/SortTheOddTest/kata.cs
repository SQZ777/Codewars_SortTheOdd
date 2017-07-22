using System;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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

        private static void sortResult(int[] expected, int[] input)
        {
            var kata = new Kata();
            var actual = kata.sortTheOdd(input);
            CollectionAssert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public int[] sortTheOdd(int[] input)
        {
            if (input.Count(m => m % 2 == 1) > 1)
            {
                Array.Reverse(input);
            }
            return input;
        }
    }
}
