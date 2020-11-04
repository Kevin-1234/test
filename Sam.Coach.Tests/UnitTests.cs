using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace Sam.Coach.Tests
{
    public class UnitTests
    {
        private readonly ILongestRisingSequenceFinder _longestRisingSequenceFinder;
        public UnitTests(ILongestRisingSequenceFinder longestRisingSequenceFinder)
        {

            _longestRisingSequenceFinder = longestRisingSequenceFinder;
        }
        [Theory]
        [InlineData(new [] {4,3,5,8,5,0,0,-3}, new [] {3,5,8})]
        // TODO: add more scenarios to ensure finder is working properly
        public async Task Can_Find(IEnumerable<int> data, IEnumerable<int> expected)
        {
            IEnumerable<int> actual = null;
            actual = _longestRisingSequenceFinder.Find(data).GetAwaiter().GetResult();
           
            // TODO: create the finder instance and get the actual result
         
            actual.Should().Equal(expected);


        }
    }
}
