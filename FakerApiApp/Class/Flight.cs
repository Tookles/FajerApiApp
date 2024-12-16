using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FakerApiApp.Class
{
    public class Flight
    {

        [JsonPropertyName("flightName")]
        public string FlightName { get; set; }

        [JsonPropertyName("flightNumber")]
        public int FlightId { get; set; }


        [JsonPropertyName("scheduleDate")]
        public string ScheduledDate { get; set; }


        [JsonPropertyName("terminal")]
        public int Terminal { get; set; }


        [JsonPropertyName("actualLandingTime")]
        public string ActualLandingTime { get; set; }


        [JsonPropertyName("aircraftType")]
        public AircraftType AircraftType { get; set; }


        [JsonPropertyName("route")]
        public Route Route { get; set; }

    }
}
