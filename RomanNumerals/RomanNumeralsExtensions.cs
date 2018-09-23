using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumerals
{
    public static class RomanNumeralsExtensions
    {
        private struct Bucket
        {
            public int Value { get; }
            public string Numerals { get; }

            public Bucket(int value, string numeral)
            {
                Value = value;
                Numerals = numeral;
            }
        }

        private static readonly List<Bucket> Buckets =
            new[]
            {
                new Bucket(1, "I"),
                new Bucket(5, "V")
            }
            .OrderByDescending(x => x.Value)
            .ToList();

        private static Bucket FindLagestFullBucket(int number) =>
            Buckets.First(x => x.Value <= number);

        public static string ToRomanNumerals(this int number)
        {
            var numerals = new StringBuilder();
            var reminder = number;
            while (reminder > 0)
            {
                var bucket = FindLagestFullBucket(reminder);
                reminder -= bucket.Value;
                numerals.Append(bucket.Numerals);
            }

            return numerals.ToString();
        }
    }
}
