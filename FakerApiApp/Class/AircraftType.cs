using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FakerApiApp.Class
{
    public class AircraftType
    {


        [JsonPropertyName("iataMain")]
        public string IataMain { get; set; }

        [JsonPropertyName("iataSub")]
        public string IataSub { get; set; }

    }
}
