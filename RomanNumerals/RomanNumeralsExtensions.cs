namespace RomanNumerals
{
    public static class RomanNumeralsExtensions
    {
        public static string ToRomanNumerals(this int number)
        {
            return number > 0 ? "I" : string.Empty;
        }
    }
}
