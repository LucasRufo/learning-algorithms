using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests
{
    public class SelectionSortTest
    {
        [Fact]
        public void SelectionSortTest_Should_ReturnOrderedList()
        {
            var list = new List<int>() { 2, 6, 1, 8, 11, 3, 9 };

            var orderedList = SelectionSort.SelectionSortAlgorithm(list);

            var assertList = new List<int>() { 1, 2, 3, 6, 8, 9, 11 };

            Assert.Equal(assertList, orderedList);
        }

        [Fact]
        public void BinarySearch_Should_ReturnNull()
        {
            var list = new List<int>();

            var orderedList = SelectionSort.SelectionSortAlgorithm(list);

            Assert.Null(orderedList);
        }
    }
}