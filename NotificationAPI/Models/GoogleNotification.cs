using Newtonsoft.Json;

namespace NotificationAPI.Models
{
    public class GoogleNotification
    {
        [JsonProperty("priority")]
        public string Priority { get; set; } = "high";
        [JsonProperty("data")]
        public DataPayload Data { get; set; }
        [JsonProperty("notification")]
        public DataPayload Notification { get; set; }
    }
}
