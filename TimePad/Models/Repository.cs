using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TimePad.Models
{
    public class Repository
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("values")]
        public List<TimePadItem> Values { get; set; }

        //[JsonProperty("name")]
        //public string Name { get; set; }

        /*
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("starts_at")]
        public string StartsAt { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("poster_image")]
        public string PosterImage { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("categories")]
        public string Categories { get; set; }

        [JsonProperty("moderation_status")]
        public string ModerationStatus { get; set; }
        */
    }
}
