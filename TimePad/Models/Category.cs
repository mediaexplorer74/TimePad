using Newtonsoft.Json.Serialization;//using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace TimePad.Models
{
    public class Category
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
       
        public override string ToString()
        {
            return $"{Name}";//return $"Category #{Id} - ({Name})";
        }
    }
}