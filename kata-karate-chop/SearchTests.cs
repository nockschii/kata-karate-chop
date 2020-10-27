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
            int[] sortedNumbers = {};

            var result = searchInteger.chop(1, sortedNumbers);

            Assert.Equal(-1, result);
        }
    }
}