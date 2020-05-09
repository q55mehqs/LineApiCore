using LineApi.WebhookEventObject.SenderSource;
using Newtonsoft.Json;

namespace LineApi.WebhookEventObject.EventObject
{
    public class TextEventObject : IEventObject
    {
        [JsonProperty(PropertyName = "type")] public string Type { get; set; } = null!;
        [JsonProperty(PropertyName = "timestamp")] public int TimeStamp { get; set; }

        [JsonProperty(PropertyName = "source")]
        public SourceObject Source { get; set; } = null!;

        [JsonProperty(PropertyName = "replyToken")]
        public string ReplyToken { get; set; } = null!;
    }
}