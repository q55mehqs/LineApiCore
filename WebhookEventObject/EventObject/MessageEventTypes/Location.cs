using Newtonsoft.Json;

namespace LineApi.WebhookEventObject.EventObject.MessageEventTypes
{
    public class Location : IEventMessage
    {
        [JsonProperty(PropertyName = "id")] public string Id { get; set; } = null!;
        [JsonProperty(PropertyName = "type")] public string Type { get; set; } = null!;
        [JsonProperty(PropertyName = "title")] public string Title { get; set; } = null!;

        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; } = null!;

        [JsonProperty(PropertyName = "latitude")]
        public decimal Latitude { get; set; }

        [JsonProperty(PropertyName = "longitude")]
        public decimal Longitude { get; set; }
    }
}