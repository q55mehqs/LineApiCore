using LineApi.WebhookEventObject.EventObject.MessageEventTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LineApi.WebhookEventObject.EventObject
{
    public class MessageEvent : IEventObject
    {
        [JsonProperty(PropertyName = "type")] public string Type { get; set; } = null!;

        [JsonProperty(PropertyName = "mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Mode Mode { get; set; }

        [JsonProperty(PropertyName = "timestamp")]
        public int TimeStamp { get; set; }

        [JsonProperty(PropertyName = "source")]
        public SourceObject Source { get; set; } = null!;

        [JsonProperty(PropertyName = "replyToken")]
        public string ReplyToken { get; set; } = null!;

        [JsonProperty(PropertyName = "message")]
        public IEventMessage Message { get; set; } = null!;
    }
}