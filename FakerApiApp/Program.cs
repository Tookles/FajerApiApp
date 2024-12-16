using FakerApiApp.Class; 

namespace FakerApiApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

           Response? returnResponse =  await FakerApi.GetBooksAsync();

            if (returnResponse != null)
            {
                Console.WriteLine(returnResponse.results[0].Author);
            }
        }
    }
}
