using TimePad.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Serialization; 
using Newtonsoft.Json;

namespace TimePad.Models
{
    // ...UserInfo
    public class TimePadOrganizationResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("description_html")]
        public string DescriptionHtml { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("logo_image")]
        public TimePadImageResponse LogoImage { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("permissions")]
        public string[] Permissions { get; set; }

    }
}
