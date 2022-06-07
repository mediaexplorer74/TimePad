using System;
using Newtonsoft.Json;

namespace WebServiceTutorial
{
    public class Repository
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("values")]
        public string Values { get; set; }

        //[JsonProperty("description")]
        //public string Description { get; set; }

        //[JsonProperty("html_url")]
        //public Uri GitHubHomeUrl { get; set; }

        //[JsonProperty("homepage")]
        //public Uri Homepage { get; set; }

        
    }
}
