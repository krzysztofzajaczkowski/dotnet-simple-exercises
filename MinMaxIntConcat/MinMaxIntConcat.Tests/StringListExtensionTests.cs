using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace MinMaxIntConcat.Tests
{
    public class StringListExtensionTests
    {

        [TestCase("12509", "50", "9", "2", "1")]
        [TestCase("333333313", "33333331", "3")]
        [TestCase("333333313", "3", "33333331")]
        [TestCase("11112121", "11","112","121")]
        [TestCase("11112121", "112","11","121")]
        [TestCase("55355455", "554", "55", "553")]
        [TestCase("555556", "5", "556", "55")]
        public void ConcatElements_ShouldBe_MinConcat(string minConcat, params string[] numbers)
        {
            var comparer = new StringComparer();
            var list = new List<string>();
            for (int i = 0; i < numbers.Length; i++)
            {
                list.InsertSorted(numbers[i], comparer.Compare);
            }
            list.Reverse();
            Assert.AreEqual(minConcat, list.ConcatElements());

        }

        [TestCase("95021","50", "9", "2", "1")]
        [TestCase("333333331", "33333331", "3")]
        [TestCase("333333331", "3", "33333331")]
        [TestCase("12111211", "11", "112", "121")]
        [TestCase("12111211", "112", "11", "121")]
        [TestCase("55554553", "554", "55", "553")]
        [TestCase("556555", "5", "556", "55")]
        public void ConcatElements_ShouldBe_MaxConcat(string maxConcat, params string[] numbers)
        {
            var comparer = new StringComparer();
            var list = new List<string>();
            for (int i = 0; i < numbers.Length; i++)
            {
                list.InsertSorted(numbers[i], comparer.Compare);
            }
            Assert.AreEqual(maxConcat, list.ConcatElements());

        }
    }
}