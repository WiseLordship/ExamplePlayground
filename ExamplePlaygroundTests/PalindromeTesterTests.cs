using ExamplePlayground;
using FluentAssertions;
using Xunit;

namespace ExamplePlaygroundTests
{
    public class PalindromeTesterTests
    {
        [Theory]
        [InlineData(null, false)]
        [InlineData("", false)]
        [InlineData("AB", false)]
        [InlineData("A", true)]
        [InlineData("ABA", true)]
        [InlineData("ABBA", true)]
        [InlineData("ABABA", true)]
        [InlineData("TacocaT", true)]
        [InlineData("tAcOCaT", true)]
        [InlineData("ABCDEFGHIJKLMNOPQRSTUVWXYZZYXWVUTSRQPONMLKJIHGFEDCBA", true)]
        public void Tests(string input, bool expected)
        {
            var result = PalindromeTester.Check(input);
            result.Should().Be(expected);
        }
    }
}
