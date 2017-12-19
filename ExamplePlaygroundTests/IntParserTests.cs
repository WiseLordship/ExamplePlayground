using ExamplePlayground;
using FluentAssertions;
using System;
using Xunit;

namespace ExamplePlaygroundTests
{
    public class IntParserTests
    {
        [Theory]
        [InlineData("1", 1)]
        [InlineData("20", 20)]
        [InlineData("33", 33)]
        [InlineData("-1", -1)]
        [InlineData("282930123", 282930123)]
        public void ParseTest(string input, int expectedValue)
        {
            var results = IntParser.Parse(input);
            results.Should().Be(expectedValue);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("a")]
        [InlineData("$%")]
        [InlineData("123%^^&3123")]
        [InlineData("123%")]
        [InlineData("-123%")]
        public void ParseFaliureTests(string input)
        {
            var action = new Action(() => { IntParser.Parse(input); });
            action.ShouldThrow<Exception>().WithMessage("Not valid input");
        }

        [Theory]
        [InlineData("2147483648")]
        [InlineData("-2147483648")]
        public void ParseExtremesTests(string input)
        {
            try
            {
                IntParser.Parse(input);
            }
            catch (Exception exception)
            {
                exception.GetType().Should().Be<ArgumentException>();
            }
        }
    }
}
