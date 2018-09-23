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

        [Theory]
        [MemberData(nameof(TestCasesSameLetterNumerals))]
        public void Number_Matching1x2xOr3xDecimals_Should_ConvertTo_SameLetterRomanNumerals(
            int number,
            string expectedRomanNumerals) =>
            number.ToRomanNumerals().Should().Be(expectedRomanNumerals);

        [Theory]
        [MemberData(nameof(TestCasesMinusOneNumerals))]
        public void Number_MatchingMinusOnePattern_Should_ConvertTo_INextRomanNumerals(
            int number,
            string expectedRomanNumerals) =>
            number.ToRomanNumerals().Should().Be(expectedRomanNumerals);

        [Theory]
        [MemberData(nameof(TestCasesMixedNumerals))]
        public void Number_Should_ConvertTo_RomanNumerals(
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

        private static readonly List<object[]> TestCasesSameLetterNumeralList =
            new List<object[]>
            {
                new object[] { 1, "I" },
                new object[] { 2, "II" },
                new object[] { 3, "III" },

                new object[] { 10, "X" },
                new object[] { 20, "XX" },
                new object[] { 30, "XXX" },

                new object[] { 100, "C" },
                new object[] { 200, "CC" },
                new object[] { 300, "CCC" },

                new object[] { 1000, "M" },
                new object[] { 2000, "MM" },
                new object[] { 3000, "MMM" }
            };

        private static readonly List<object[]> TestCasesMinusOneNumeralList =
            new List<object[]>
            {
                new object[] { 4, "IV" },
                new object[] { 9, "IX" },
                new object[] { 40, "XL" },
                new object[] { 90, "XC" },
                new object[] { 400, "CD" },
                new object[] { 900, "CM" }
            };

        private static readonly List<object[]> TestCasesMixedNumeralsList =
            new List<object[]>
            {
                new object[] { 39, "XXXIX" },
                new object[] { 246, "CCXLVI" },
                new object[] { 207, "CCVII" },
                new object[] { 1066, "MLXVI" },
                new object[] { 1776, "MDCCLXXVI" },
                new object[] { 1873, "MDCCCLXXIII" },
                new object[] { 1984, "MCMLXXXIV" },
                new object[] { 2018, "MMXVIII" }
            };

        // ReSharper disable MemberCanBePrivate.Global
        public static IEnumerable<object[]> TestCasesSingleLetterNumerals => TestCasesSingleLetterNumeralList;
        public static IEnumerable<object[]> TestCasesSameLetterNumerals => TestCasesSameLetterNumeralList;
        public static IEnumerable<object[]> TestCasesMinusOneNumerals => TestCasesMinusOneNumeralList;
        public static IEnumerable<object[]> TestCasesMixedNumerals => TestCasesMixedNumeralsList;
        // ReSharper restore MemberCanBePrivate.Global
    }
}
