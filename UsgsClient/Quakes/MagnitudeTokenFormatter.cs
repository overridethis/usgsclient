using System;
using UsgsClient.Common;

namespace UsgsClient.Quakes
{
    public static class MagnitudeTokenFormatter
    {
        public static string Format(Magnitude magnitude)
        {
            var description = magnitude.GetDescription()
               ?? magnitude.ToString();
            
            return description
                .ToLower();
        }
    }
}
