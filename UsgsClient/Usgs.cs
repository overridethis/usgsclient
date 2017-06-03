using System;
using UsgsClient.Quakes;

namespace UsgsClient
{
    public static class Usgs
    {
        public static class Quakes
        {
            public const string KnownFeedUri = "https://earthquake.usgs.gov/earthquakes/feed/v1.0";

            public static IQuakesFeedService Feed(string feedBaseUri = KnownFeedUri)
            {
                var config = new Common.Config
                {
                    FeedUri = feedBaseUri
                };

                var builder = new QuakesUriBuilder(config);
                return new QuakesFeedService(builder, new Common.SimpleHttp());
            }
        }
    }
}
