using System;
using UsgsClient.Quakes;
using Xunit;

namespace UsgsClient.Tests.Quakes
{
    public class MagnitudeTokenFormatterTests
    {
        [Fact]
        public void Format_can_format_enum_values_without_description()
        {
            var all = Magnitude.All;
            var expected = all.ToString().ToLower();

            FormatTest(all, expected);
        }

        [Fact]
        public void Format_can_format_enum_values_with_description()
        {
            var mag1 = Magnitude.M1_0;
            var expected = "1.0"; // Known Value.

            FormatTest(mag1, expected);
        }

        private static void FormatTest(
            Magnitude mag,
            string expected)
        {
            // Arrange.
            // Act.
            var actual = MagnitudeTokenFormatter.Format(mag);

            // Assert.
            Assert.Equal(expected, actual);
        }
    }
}
