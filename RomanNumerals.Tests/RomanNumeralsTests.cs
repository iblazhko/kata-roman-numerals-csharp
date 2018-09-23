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

        [Fact]
        public void Number_1_ConvertsTo_I()
        {
            1.ToRomanNumerals().Should().Be("I");
        }

        [Fact]
        public void Number_2_ConvertsTo_II()
        {
            2.ToRomanNumerals().Should().Be("II");
        }

        [Fact]
        public void Number_5_ConvertsTo_V()
        {
            5.ToRomanNumerals().Should().Be("V");
        }
    }
}
