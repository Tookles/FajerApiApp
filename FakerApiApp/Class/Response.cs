using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Text.Json.Serialization; 

namespace FakerApiApp.Class
{
    public class Response
    {
        [JsonPropertyName("status")]
        public String status {  get; set; }


        [JsonPropertyName("code")]
        public int statusCode { get; set; }


        [JsonPropertyName("data")]
        public List<Book> results { get; set; }

    }
}
