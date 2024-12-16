using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FakerApiApp.Class
{
    public class SchipolAirport
    {
        private static readonly string BASE_URL = "https://api.schiphol.nl/public-flights/flights?includedelays=false&page=0&sort=%2BscheduleTime";

        public static async Task<FlightResponse> GetSchipolAirportFlights()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                HttpRequestMessage request = new HttpRequestMessage();

                request.RequestUri = new Uri(BASE_URL);
                request.Method = HttpMethod.Get;
                request.Headers.Add("Accept", "application/json");
                request.Headers.Add("app_id", "267acf85");
                request.Headers.Add("app_key", "28c41226667be111948e6b826078bcbd");
                request.Headers.Add("ResourceVersion", "v4");

                try
                {
                    HttpResponseMessage response = await httpClient.SendAsync(request);

                    string responseBody = await response.Content.ReadAsStringAsync();


                    if (!string.IsNullOrEmpty(responseBody))
                    {
                        Console.WriteLine(responseBody);    
                        return JsonSerializer.Deserialize<FlightResponse>(responseBody);
                    }
                    else
                    {
                        return null;
                    }



                }
                catch (HttpRequestException ex)
                {
                    Console.Error.WriteLine(ex.Message);
                    return null; 
                }

            }
        }

    }
}
