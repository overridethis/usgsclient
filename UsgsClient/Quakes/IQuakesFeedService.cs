using System.Threading.Tasks;
using GeoJSON.Net.Feature;

namespace UsgsClient.Quakes
{
    public interface IQuakesFeedService
    {
        Task<Feature> Detail(
            string quakeId);

        Task<FeatureCollection> Summary(
            Magnitude magnitude = Magnitude.All,
            Timeframe timeframe = Timeframe.Day);
    }
}
