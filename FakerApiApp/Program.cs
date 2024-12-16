using FakerApiApp.Class; 

namespace FakerApiApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            FlightResponse? response = await SchipolAirport.GetSchipolAirportFlights();

            Console.WriteLine(response.results[1].FlightName);
            Console.WriteLine(response.results[1].Route.Visa);
            Console.WriteLine(response.results[1].Route.Destinations[0]);
            Console.WriteLine(response.results[1].AircraftType.IataMain);

            Console.WriteLine(response.results[1].FlightId);


        }
    }
}
