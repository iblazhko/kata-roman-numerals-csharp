using System;
using System.Collections.Generic;
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
        public void Number_2_ConvertsTo_II()
        {
            2.ToRomanNumerals().Should().Be("II");
        }

        [Fact]
        public void Number_4_ConvertsTo_IV()
        {
            4.ToRomanNumerals().Should().Be("IV");
        }

        [Theory]
        [MemberData(nameof(TestCasesSingleLetterNumerals))]
        public void Number_MatchingNumeralsAlphabet_Should_ConvertTo_SingleLetterRomanNumerals(
            int number,
            string expectedRomanNumerals) =>
            number.ToRomanNumerals().Should().Be(expectedRomanNumerals);

        private static readonly List<object[]> TestCasesSingleLetterNumeralList =
            new List<object[]>
            {
                new object[] { 1, "I" },
                new object[] { 5, "V" },
                new object[] { 10, "X" },
                new object[] { 50, "L" },
                new object[] { 100, "C" },
                new object[] { 500, "D" },
                new object[] { 1000, "M" }
            };

        // ReSharper disable once MemberCanBePrivate.Global
        public static IEnumerable<object[]> TestCasesSingleLetterNumerals => TestCasesSingleLetterNumeralList;
    }
}
