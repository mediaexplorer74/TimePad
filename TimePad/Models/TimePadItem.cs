using TimePad.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Serialization; 
using Newtonsoft.Json;

namespace TimePad.Models
{

    public class TimePadItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("starts_at")]
        public string StartsAt { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        //[JsonProperty("description")]
        //public string Description { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        //[JsonProperty("poster_image")]
        //public string PosterImage { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("location_plain")]
        public string LocationPlain { get; set; }

        [JsonProperty("categories")]
        public List<Category> Categories { get; set; }

        [JsonProperty("categories_plain")]
        public string CategoriesPlain { get; set; }

        [JsonProperty("moderation_status")]
        public string ModerationStatus { get; set; }
    }
}
