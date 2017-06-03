using System;
using System.Linq;
using System.Threading.Tasks;
using ConsoleTables;
using UsgsClient;
using UsgsClient.Quakes;

namespace SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Task
                .Run(GetQuakes)
                .Wait();

            Console.WriteLine("Press any key to continue. [KEY]");
            Console.ReadKey();
        }

        private static async Task GetQuakes()
        {
            var svc = Usgs
                .Quakes
                .Feed();

            var features = await svc
                .Summary(
                    Magnitude.Significant,
                    Timeframe.Week);

            var quakes = features
                .Features
                .Select(QuakeModel.MapFrom)
                .ToList();

            Console.WriteLine("List of Significant Quake(s)");
            ConsoleTable
                .From(quakes)
                .Write();

            var quake = await svc.Detail(quakes.First().Id);

            Console.WriteLine("First Quake on list.");

            ConsoleTable
                .From(new[] { QuakeModel.MapFrom(quake) })
                .Write();
        }
    }
}
