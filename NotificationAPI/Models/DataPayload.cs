using Newtonsoft.Json;

namespace NotificationAPI.Models
{
    public class DataPayload
    {
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("body")]
        public string Body { get; set; }
    }

}
