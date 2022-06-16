using TimePad.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Serialization; 
using Newtonsoft.Json;

namespace TimePad.Models
{
    // ...UserInfo
    public class TimePadUserInfo
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("client_id")]
        public string ClientId { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("user_email")]
        public string UserEmail { get; set; }

        [JsonProperty("organizations")]
        public List<TimePadOrganizationResponse> Organizations { get; set; }

        [JsonProperty("orders")]
        public List<TimePadRegistrationOrderResponse> Orders { get; set; }
        
    }
}
