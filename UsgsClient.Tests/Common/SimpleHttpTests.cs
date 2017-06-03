using GeoJSON.Net.Feature;
using System;
using System.Threading.Tasks;
using UsgsClient.Common;
using Xunit;

namespace UsgsClient.Tests
{
    public class SimpleHttpTests
    {
        [Fact]
        public async Task Can_make_simple_http_requests()
        {
            // Arrange.
            var client = new SimpleHttp();
            var uri = new Uri("https://earthquake.usgs.gov/earthquakes/feed/v1.0/summary/significant_week.geojson");

            // Act.
            var rsp = await client.GetAsync<FeatureCollection>(uri);

            // Assert.
            Assert.NotNull(rsp);
        }
    }
}
