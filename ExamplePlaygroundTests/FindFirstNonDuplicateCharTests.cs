using ExamplePlayground;
using FluentAssertions;
using Xunit;

namespace ExamplePlaygroundTests
{
    public class FindFirstNonDuplicateCharTests
    {
        public class FindTests
        {
            [Theory]
            [InlineData("", "")]
            [InlineData(null, null)]
            [InlineData("a", "a")]
            [InlineData("aa", "")]
            [InlineData("aba", "b")]
            [InlineData("caba", "c")]
            [InlineData("faaad", "f")]
            [InlineData("ABCDABCDABCDABCDE", "E")] //error
            [InlineData("ABCDABCDABCDABCDEFGHIJKLMFNOEP", "G")] //error
            public void Tests(string input, string expected)
            {
                var result = FindFirstNonDuplicateChar.Find(input);
                result.Should().Be(expected);
            }
        }
    }
}
