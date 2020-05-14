using System.Collections.Generic;
using Newtonsoft.Json;

namespace LineApi.WebhookEventObject.EventObject.MessageEventTypes
{
    public class TextEventMessage : IEventMessage
    {
        [JsonProperty(PropertyName = "id")] public string Id { get; set; } = null!;
        [JsonProperty(PropertyName = "type")] public string Type { get; set; } = null!;
        [JsonProperty(PropertyName = "text")] public string Text { get; set; } = null!;

        [JsonProperty(PropertyName = "emojis")]
        public IEnumerable<EventEmoji> Emojis { get; set; } = null!;
    }
}