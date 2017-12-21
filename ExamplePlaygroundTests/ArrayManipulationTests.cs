using ExamplePlayground;
using FluentAssertions;
using Xunit;
namespace ExamplePlaygroundTests
{
    public class ArrayManipulationTests
    {
        [Theory]
        [InlineData(new int[0], new int[0])]
        [InlineData(null, null)]
        [InlineData(new int[] { 1 }, new int[] { 1 })]
        [InlineData(new int[] { 1, 2 }, new int[] { 1, 2 })]
        [InlineData(new int[] { 3, 2, 1 }, new int[] { 1, 2, 3 })]
        [InlineData(new int[] { -1, 2, -421, 23 }, new int[] { -421, -1, 2, 23 })]
        [InlineData(new int[] { 10, 304, 124, 1235, 342, 2313, 12, 3, 1 }, new int[] { 1, 3, 10, 12, 124, 304, 342, 1235, 2313 })]
        public void ArrayManipulationTest(int[] input, int[] expected)
        {
            var result = ArrayManipulation.StortArrayLowHigh(input);
            result.Should().Equal(expected);
        }
    }
}
