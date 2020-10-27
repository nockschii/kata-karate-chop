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

        [Fact]
        public void SearchInteger_ArrayContainsTargetInteger_Zero()
        {
            var searchInteger = new SearchInteger();
            int[] sortedNumbers = { 1 };

            var result = searchInteger.chop(1, sortedNumbers);

            Assert.Equal(0, result);
        }

        [Fact]
        public void SearchInteger_ArrayContainsMorThanTargetInteger_Zero()
        {
            var searchInteger = new SearchInteger();
            int[] sortedNumbers = { 1, 2 };

            var result = searchInteger.chop(2, sortedNumbers);

            Assert.Equal(1, result);
        }

        [Fact]
        public void SearchInteger_ArrayDoesnNotContainTargetInteger_Minus1()
        {
            var searchInteger = new SearchInteger();
            int[] sortedNumbers = { 1, 2 };

            var result = searchInteger.chop(3, sortedNumbers);

            Assert.Equal(-1, result);
        }
    }
}
