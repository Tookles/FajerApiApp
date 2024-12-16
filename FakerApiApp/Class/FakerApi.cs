using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FakerApiApp.Class
{
    public class FakerApi
    {
        private static readonly string BASE_URL = "https://fakerapi.it/api/v1/books";

        public static async Task<Response> GetBooksAsync(string param)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                string url = $"{BASE_URL}?id={param}";
                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync(BASE_URL);

                    string responseBody = await response.Content.ReadAsStringAsync();


                    if (!string.IsNullOrEmpty(responseBody))
                    {
                        return JsonSerializer.Deserialize<Response>(responseBody);
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
