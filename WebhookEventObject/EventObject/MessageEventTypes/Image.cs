using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LineApi.WebhookEventObject.EventObject.MessageEventTypes
{
    public class Image : IEventMessage
    {
        [JsonProperty(PropertyName = "id")] public string Id { get; set; } = null!;
        [JsonProperty(PropertyName = "type")] public string Type { get; set; } = null!;

        [JsonProperty(PropertyName = "contentProvider")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ContentProvider ContentProvider { get; set; } = null!;
    }
}