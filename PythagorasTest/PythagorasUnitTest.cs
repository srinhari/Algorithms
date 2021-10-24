using NUnit.Framework;
using Pythagoras;
using System;
using System.Collections.Generic;

namespace PythagorasTest
{
    public class PythagorasUnitTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestQuickSort()
        {
            Solution sol = new Solution();

            Console.WriteLine("Null input");
            Assert.AreEqual(null, sol.QuickSort(null));

            Console.WriteLine("Single input");
            Assert.AreEqual(new List<int> { 1 }, sol.QuickSort(new List<int> { 1 }));

            Console.WriteLine("Unsorted case");
            List<int> input = new List<int> { 5, 1, 7, 2, 6, -3, 5, 7, -1 };
            List<int> output = input;
            output.Sort();
            Assert.AreEqual(output, sol.QuickSort(input));

        }
    }
}