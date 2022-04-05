using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests
{
    public class RecursionTest
    {
        [Fact]
        public void RecursionListSum_Should_ReturnCorrectSum()
        {
            var list = new List<int>() { 1, 2, 3, 4, 5 };

            var sum = Recursion.RecursionListSum(list);

            Assert.Equal(15, sum);
        }

        [Fact]
        public void RecursionListSum_Should_ReturnOnlyFirstElement()
        {
            var list = new List<int>() { 1 };

            var sum = Recursion.RecursionListSum(list);

            Assert.Equal(1, sum);
        }

        [Fact]
        public void RecursionListCount_Should_ReturnCorrectCount()
        {
            var list = new List<int>() { 1, 2, 3, 4 };

            var count = Recursion.RecursionListCount(list);

            Assert.Equal(4, count);
        }

        [Fact]
        public void RecursionListCount_Should_ReturnOneCount()
        {
            var list = new List<int>() { 1 };

            var count = Recursion.RecursionListCount(list);

            Assert.Equal(1, count);
        }

        [Fact]
        public void RecursionMaxValue_Should_ReturnCorrectMaxValue()
        {
            var list = new List<int>() { 12, 5, 72, 90, 100, 56, 2 };

            var maxValue = Recursion.RecursionMaxValue(list);

            Assert.Equal(100, maxValue);
        }

        [Fact]
        public void RecursionMaxValue_Should_ReturnMaxValueWithOnlyTwoElements()
        {
            var list = new List<int>() { 1, 4 };

            var maxValue = Recursion.RecursionMaxValue(list);

            Assert.Equal(4, maxValue);
        }
    }
}