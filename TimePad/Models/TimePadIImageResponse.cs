using TimePad.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Serialization; 
using Newtonsoft.Json;

namespace TimePad.Models
{
    // ...UserInfo
    public class TimePadImageResponse
    {
       
        [JsonProperty("default_url")]
        public string DefaultUrl { get; set; }

        [JsonProperty("uploadcare_url")]
        public string UploadCore { get; set; }
       
    }
}
