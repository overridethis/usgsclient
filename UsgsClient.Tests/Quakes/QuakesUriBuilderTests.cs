using Moq;
using UsgsClient.Common;
using UsgsClient.Quakes;
using Xunit;

namespace UsgsClient.Tests.Quakes
{
    public class QuakesUriBuilderTests
    {
        [Fact]
        public void Build_works_for_summary_call()
        {
            // Arrange.
            var config = new Mock<IConfig>();
            var builder = new QuakesUriBuilder(config.Object);
            var expected = "http://localhost/summary/all_day.geojson";

            config
                .Setup(svc => svc.FeedUri)
                .Returns($"http://localhost");

            // Act
            var actual = builder.ForSummary(Magnitude.All, Timeframe.Day).ToString();

            //Assert.
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Build_works_for_detail_call()
        {
            // Arrange.
            var quakeId = "quake_id";
            var config = new Mock<IConfig>();
            var builder = new QuakesUriBuilder(config.Object);
            var expected = "http://localhost/detail/quake_id.geojson";

            config
                .Setup(svc => svc.FeedUri)
                .Returns($"http://localhost");

            // Act
            var actual = builder.ForDetail(quakeId).ToString();

            //Assert.
            Assert.Equal(expected, actual);
        }
    }
}
