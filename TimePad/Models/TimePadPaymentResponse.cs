using System;
using Newtonsoft.Json.Serialization;//using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace TimePad.Models
{
    public class TimePadPaymentResponse
    {
        [JsonProperty("amount")]
        public float Amount { get; set; }               

        [JsonProperty("paid_at")]
        public string PaidAt { get; set; }

        [JsonProperty("payment_type")]
        public string PaymentType { get; set; }

        [JsonProperty("payment_link")]
        public string PaymentLink { get; set; }
    }
}