using ExamplePlayground;
using FluentAssertions;
using Xunit;

namespace ExamplePlaygroundTests
{
    public class ReverseStringTests
    {
        [Theory]
        [InlineData("", "")]
        [InlineData(null, null)]
        [InlineData("A", "A")]
        [InlineData("b", "b")]
        [InlineData("CC", "CC")]
        [InlineData("Cd", "dC")]
        [InlineData("ABC", "CBA")]
        [InlineData("Help", "pleH")]
        [InlineData("Thisisalongseentencetotestlength", "htgneltsetotecnetneesgnolasisihT")]
        public void ReverseStringTest(string input, string expected)
        {
            var result = ReverseString.Reverse(input);
            result.Should().Be(expected);
        }
    }
}
