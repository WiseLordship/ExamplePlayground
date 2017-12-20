using ExamplePlayground;
using FluentAssertions;
using Xunit;

namespace ExamplePlaygroundTests
{
    public class StringManipulationTests
    {
        [Theory]
        [InlineData("","")]
        [InlineData(null,null)]
        [InlineData("A","A")]
        [InlineData("b","b")]
        [InlineData("CC","CC")]
        [InlineData("Cd","dC")]
        [InlineData("ABC","CBA")]
        [InlineData("Help","pleH")]
        [InlineData("Thisisalongseentencetotestlength", "htgneltsetotecnetneesgnolasisihT")]
        public void StringManipulationTest(string input, string expected)
        {
            var result = StringManipulation.ReverseString(input);
            result.Should().Be(expected);
        }

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
        public void RemoveDuplicateCharsTests(string input, string expected)
        {
            var result = StringManipulation.RemoveDuplicateChars(input);
            result.Should().Be(expected);
        }
    }
}
