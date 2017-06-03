using System;
namespace UsgsClient.Quakes
{
    public static class TimeframeTokenFormatter
    {
        public static string Format(Timeframe timeframe)
        {
            return timeframe
                .ToString()
                .ToLower();
        }
    }
}
