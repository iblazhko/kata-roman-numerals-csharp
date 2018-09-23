using System.Collections.Generic;

namespace RomanNumerals
{
    public static class RomanNumeralsExtensions
    {
        private static readonly Dictionary<int, string> numerals = new Dictionary<int, string>
        {
            { 1, "I" },
            { 2, "II" },
            { 5, "V" }
        };

        public static string ToRomanNumerals(this int number)
        {
            return number > 0 ? numerals[number] : string.Empty;
        }
    }
}
