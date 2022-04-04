using Xunit;

namespace Algorithms.Tests
{
    public class BinarySearchTest
    {
        [Fact]
        public void BinarySearch_Should_ReturnCorrectIndex()
        {
            var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var itemToFind = 8;

            var index = BinarySearch.BinarySearchAlgorithm(array, itemToFind);

            Assert.Equal(7, index);
        }

        [Fact]
        public void BinarySearch_Should_ReturnNull()
        {
            var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var itemToFind = -1;

            var index = BinarySearch.BinarySearchAlgorithm(array, itemToFind);

            Assert.Null(index);
        }
    }
}