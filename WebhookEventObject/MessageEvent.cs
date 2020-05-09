using LineApi.WebhookEventObject.EventObject;
using Newtonsoft.Json;

namespace LineApi.WebhookEventObject
{
    public class MessageEvent
    {
        [JsonProperty(PropertyName = "type")] public string Type { get; set; } = null!;

        [JsonProperty(PropertyName = "replyToken")]
        public string ReplyToke { get; set; } = null!;

        [JsonProperty(PropertyName = "message")]
        public IEventObject Event { get; set; } = null!;
    }
}