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
                new Bucket(4, "IV"),
                new Bucket(5, "V"),
                new Bucket(10, "X"),
                new Bucket(50, "L"),
                new Bucket(100, "C"),
                new Bucket(500, "D"),
                new Bucket(1000, "M")
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
