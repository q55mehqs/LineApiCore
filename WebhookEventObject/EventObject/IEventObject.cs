using Newtonsoft.Json;

namespace LineApi.WebhookEventObject.EventObject
{
    public interface IEventObject
    {
        [JsonProperty(PropertyName = "type")] public string Type { get; set; }

        [JsonProperty(PropertyName = "mode")] public Mode Mode { get; set; }

        [JsonProperty(PropertyName = "timestamp")]
        public int TimeStamp { get; set; }

        [JsonProperty(PropertyName = "source")]
        public SourceObject Source { get; set; }
    }
}