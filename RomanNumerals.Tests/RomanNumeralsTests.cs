using System;
using Xunit;
using FluentAssertions;

namespace RomanNumerals.Tests
{
    public class RomanNumeralsTests
    {
        [Fact]
        public void Number_0_ConvertsTo_Empty()
        {
            0.ToRomanNumerals().Should().Be(string.Empty);
        }
    }
}
