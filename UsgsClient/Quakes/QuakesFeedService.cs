﻿using System;
using System.Threading.Tasks;
using GeoJSON.Net.Feature;
using UsgsClient.Common;

namespace UsgsClient.Quakes
{
    public class QuakesFeedService : IQuakesFeedService
    {
        private readonly ISimpleHttp _http;
        private readonly IQuakesUriBuilder _uriBuilder;

        public QuakesFeedService(
            IQuakesUriBuilder uriBuilder,
            ISimpleHttp http)
        {
            this._uriBuilder = uriBuilder;
            this._http = http;
        }

        public async Task<Feature> Detail(
            string quakeId)
        {
            var quakeUri = _uriBuilder.ForDetail(quakeId);
            return await _http.GetAsync<Feature>(quakeUri);
        }

        public async Task<FeatureCollection> Summary(
            Magnitude magnitude = Magnitude.All, 
            Timeframe timeframe = Timeframe.Day)
        {
            var quakesUri = _uriBuilder.ForSummary(magnitude, timeframe);
            return await _http.GetAsync<FeatureCollection>(quakesUri);
        }
    }
}
