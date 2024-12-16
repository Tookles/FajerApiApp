using FakerApiApp.Class.FakerApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FakerApiApp.Class
{
    public class FlightResponse
    {

        [JsonPropertyName("flights")]
        public List<Flight> results { get; set; }


    }
}
