using Newtonsoft.Json.Serialization;//using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace TimePad.Models
{
    public class Location
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        public override string ToString()
        {
            return $"Category {Country}, {City}, {Address}";
        }
    }
}