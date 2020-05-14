using Newtonsoft.Json;

namespace LineApi.WebhookEventObject.EventObject.MessageEventTypes
{
    public class Audio : IEventMessage
    {
        [JsonProperty(PropertyName = "id")] public string Id { get; set; } = null!;
        [JsonProperty(PropertyName = "type")] public string Type { get; set; } = null!;

        [JsonProperty(PropertyName = "duration")]
        public int DurationMilliSecond { get; set; }

        [JsonProperty(PropertyName = "contentProvider")]
        public ContentProvider ContentProvider { get; set; } = null!;
    }
}