using TimePad.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Serialization; 
using Newtonsoft.Json;

namespace TimePad.Models
{
    // ...UserInfo
    public class TimePadRegistrationOrderResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("status")]
        public TimePadOrderStatusResponse Status { get; set; }

        [JsonProperty("mail")]
        public string Mail { get; set; }

        [JsonProperty("payment")]
        public TimePadPaymentResponse Payment { get; set; }

        [JsonProperty("tickets")]
        public TimePadTicketResponse Tickets { get; set; }

        [JsonProperty("answers")]
        public object Answers { get; set; }

        [JsonProperty("promo_codes")]
        public string[] PromoCodes { get; set; }

        //[JsonProperty("event")]
        //public TimePadOrderEventResponse Event { get; set; }

        //[JsonProperty("referrer")]
        //public TimePadOrderReferrerResponse Referrer { get; set; }

        [JsonProperty("subscribed_to_newsletter")]
        public bool SubscribedToNewsletter { get; set; }

    }
}
