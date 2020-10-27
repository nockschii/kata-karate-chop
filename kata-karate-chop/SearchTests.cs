using System;
using Xunit;

namespace kata_karate_chop
{
    public class SearchTests
    {
        [Fact]
        public void SearchInteger_EmptyArray_Minus1()
        {
            var searchInteger = new SearchInteger();
            int[] sortedNumbers = { };

            var result = searchInteger.chop(1, sortedNumbers);

            Assert.Equal(-1, result);
        }

        [Theory]
        [InlineData(1, 0)]
        [InlineData(3, 1)]
        [InlineData(7, 2)]
        [InlineData(9, 3)]
        [InlineData(15, 4)]
        public void SearchTargetInteger_ArrayDoesContainTargetInteger_Index(int target, int expectedIndex)
        {
            var searchInteger = new SearchInteger();
            int[] sortedNumbers = { 1, 3, 7, 9, 15 };

            var result = searchInteger.chop(target, sortedNumbers);

            Assert.Equal(expectedIndex, result);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(8)]
        [InlineData(16)]
        public void SearchTargetInteger_ArrayDoesNotContainTargetInteger_Minus1(int target)
        {
            var searchInteger = new SearchInteger();
            int[] sortedNumbers = { 1, 3, 7, 9, 15 };

            var result = searchInteger.chop(target, sortedNumbers);

            Assert.Equal(-1, result);
        }
    }
}
