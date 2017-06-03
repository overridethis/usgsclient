using System;
using UsgsClient.Quakes;
using Xunit;

namespace UsgsClient.Tests.Quakes
{
    public class TimeframeTokenFormatterTests
    {
        [Fact]
        public void Format_to_lowers_timeframe_names()
        {
            // Arrange.
            var month = Timeframe.Month;
            var expected = month.ToString().ToLower();

            // Act.
            var actual = TimeframeTokenFormatter.Format(month);

            // Assert.
            Assert.Equal(expected, actual);
        }

    }
}
