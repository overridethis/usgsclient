using System;
using UsgsClient.Common;

namespace UsgsClient.Quakes
{
    public class QuakesUriBuilder : IQuakesUriBuilder
    {
        private readonly IConfig _config;

        public QuakesUriBuilder(IConfig config)
        {
            this._config = config;
        }

        public Uri ForDetail(
            string quakeId)
        {

            var usgsUri = $"{_config.FeedUri}/detail/{quakeId}.geojson";;

            return new Uri(usgsUri);
        }

        public Uri ForSummary(
            Magnitude magnitude,
            Timeframe timeframe)
        {
            var usgsUri = $"{_config.FeedUri}/summary/{{magnitude}}_{{timeframe}}.geojson";;

			return new Uri(usgsUri
                           .Replace("{magnitude}", MagnitudeTokenFormatter.Format(magnitude))
                           .Replace("{timeframe}", TimeframeTokenFormatter.Format(timeframe)));
        }
    }

}