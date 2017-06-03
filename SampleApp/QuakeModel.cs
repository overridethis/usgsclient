using System;
using GeoJSON.Net.Feature;
using GeoJSON.Net.Geometry;

namespace SampleApp
{
    public class QuakeModel
    {
        public string Id { get; private set; }

        public string Description { get; private set; }

        public double Magnitude { get; private set; }

        public double Longitude { get; private set; }

		public double Latitude { get; private set; }

        public static QuakeModel MapFrom(Feature feature)
        {
            return new QuakeModel
            {
                Id = feature.Id,
                Description = feature.Properties["place"].ToString(),
				Magnitude = double.Parse(feature.Properties["mag"].ToString()),
                Longitude = ((Point)feature.Geometry).Coordinates.Longitude,
				Latitude = ((Point)feature.Geometry).Coordinates.Latitude
            };
        }
    }
}
