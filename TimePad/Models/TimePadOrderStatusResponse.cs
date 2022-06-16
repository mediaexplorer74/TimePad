using TimePad.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Serialization; 
using Newtonsoft.Json;

namespace TimePad.Models
{
    // ...UserInfo
    public class TimePadOrderStatusResponse
    {
       
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }       
    }
}
