using ExamplePlayground;
using FluentAssertions;
using Xunit;

namespace ExamplePlaygroundTests
{
    public class RemoveDuplicateCharsTests
    {

        [Theory]
        [InlineData("", "")]
        [InlineData(null, null)]
        [InlineData("a", "a")]
        [InlineData("aa", "a")]
        [InlineData("ba", "ba")]
        [InlineData("caba", "caba")]
        [InlineData("faaad", "fad")]
        [InlineData("AAAA BBBB", "A B")]
        [InlineData("AaaAaA BbBbbBbbbBBb", "AaAaA BbBbBbBb")]
        [InlineData("ABABAB BABABABA", "ABABAB BABABABA")]
        public void Tests(string input, string expected)
        {
            var result = RemoveDuplicateChars.Remove(input);
            result.Should().Be(expected);
        }
    }
}
