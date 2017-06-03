using System;

namespace UsgsClient.Quakes
{
    public interface IQuakesUriBuilder
    {
        Uri ForSummary(
            Magnitude magnitude,
            Timeframe timeframe);

        Uri ForDetail(
            string id);
    }
}
