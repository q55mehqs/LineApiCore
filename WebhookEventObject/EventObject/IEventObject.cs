using LineApi.WebhookEventObject.SenderSource;
using Newtonsoft.Json;

namespace LineApi.WebhookEventObject.EventObject
{
    public interface IEventObject
    {
        [JsonProperty(PropertyName = "type")] public string Type { get; set; }

        [JsonProperty(PropertyName = "timestamp")]
        public int TimeStamp { get; set; }

        [JsonProperty(PropertyName = "source")]
        public SourceObject Source { get; set; }

        [JsonProperty(PropertyName = "replyToken")]
        public string ReplyToken { get; set; }
    }
}