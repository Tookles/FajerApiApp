using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FakerApiApp.Class
{
    public class Route
    {

        [JsonPropertyName("destinations")]
        public List<string> Destinations { get; set; }

        [JsonPropertyName("eu")]
        public string EU { get; set; }

        [JsonPropertyName("visa")]
        public bool Visa { get; set; }

    }
}
